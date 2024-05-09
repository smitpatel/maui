﻿using NUnit.Framework;
using UITest.Appium;
using UITest.Core;

namespace Microsoft.Maui.AppiumTests.Issues
{
	public class Issue18857 : _IssuesUITest
	{
		public Issue18857(TestDevice device)
			: base(device)
		{ }

		public override string Issue => "ImageButton Padding & Ripple effect stops working with .NET 8";

		[Test]
		[Category(UITestCategories.ImageButton)]
		public async Task GradientImageButtonBackground()
		{
			this.IgnoreIfPlatforms(new[]
			{
				TestDevice.Mac,
				TestDevice.iOS,
				TestDevice.Windows
			});

			App.WaitForElement("TestImageButton");

			App.Tap("TestRemoveBackgroundButton");
			App.Tap("TestUpdateBackgroundButton");

			await Task.Delay(500);

			VerifyScreenshot();
		}
	}
}