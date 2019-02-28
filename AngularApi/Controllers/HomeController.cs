using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularApi.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			return View();
		}

		[HttpPost]
		public ActionResult SearchReportManager(string UserId, string RoleId)
		{
			ViewBag.Title = "Home Page";

			return Json(new {Name = "Hemanth" });
		}
	}
}
