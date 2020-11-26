using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyStore.Models;

namespace BeautyStore.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
