using Hidistro.UI.ControlPanel.Utility;
using System;
using System.Web.UI.HtmlControls;

namespace Hidistro.UI.Web.Admin.promotion
{
	public class PrizeListsGuaGuaLe : AdminPage
	{
		protected System.Web.UI.HtmlControls.HtmlForm thisForm;

		protected UCPrizeLists UCPrizeLists1;

		protected PrizeListsGuaGuaLe() : base("m08", "yxp11")
		{
		}

		protected void Page_Load(object sender, System.EventArgs e)
		{
			try
			{
				int.Parse(base.Request.QueryString["gameId"]);
			}
			catch (System.Exception)
			{
				base.GotoResourceNotFound();
			}
		}
	}
}
