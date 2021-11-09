using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2PARCIAL.Controllers
{
    public class montoController : Controller
    {
        // GET: monto
        public ActionResult Index()
        {
            return View();
        }

        // GET: monto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: monto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: monto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: monto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: monto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: monto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: monto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
