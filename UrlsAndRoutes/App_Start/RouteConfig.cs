﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("MyRoute", "{controller}/{action}/{id}",
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = "DefaultId"
                });

            //routes.MapRoute("ShopSchema2", "Shop/OldAction",
            //    new { controller = "Home", action = "Index" });

            //routes.MapRoute("ShopSchema", "Shop/{action}",
            //    new { controller = "Home"});

            //routes.MapRoute("", "X{controller}/{action}");

            //routes.MapRoute("MyRoute", "{controller}/{action}",
            //    new { controller = "Home", action = "Index" });

            //routes.MapRoute("", "Public/{controller}/{action}",
            //    new { controller = "Home", action = "Index" });
        }
    }
}
