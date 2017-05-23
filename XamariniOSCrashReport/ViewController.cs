using System;

using UIKit;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Crashes;
namespace XamariniOSCrashReport
{
	public partial class ViewController : UIViewController
	{
		public const string MOBILE_CENTER_ID= "8f7b790d-cafc-4555-ad29-5a784375ac89";
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			MobileCenter.Start(MOBILE_CENTER_ID, typeof(Crashes));
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void BtnClick_TouchUpInside(UIButton sender)
		{
			throw new NotImplementedException("Not Implement Exception");
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
