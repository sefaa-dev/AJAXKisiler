using AjaxKisiler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxKisiler.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult KisiListele(int id)
        {
            List<Kisiler> kisiler = new List<Kisiler>
            {
                new Kisiler {Id=1,Isim="Tolga",Sehir="İstanbul"},
                new Kisiler {Id=2,Isim="Hayatı Kodlamak",Sehir="Youtube"},
                new Kisiler {Id=3,Isim="X",Sehir="Y"},
            };
            Kisiler kisi = kisiler.FirstOrDefault(x => x.Id == id);
            return Json(kisi, JsonRequestBehavior.AllowGet);
        
        }
    }
}