﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morphous.Native.Models
{
    public interface IZone
    {
        string Name { get; }
        IList<IContentElement> Elements { get; }
    }

    public class Zone : ObservableObject, IZone
    {
        public string Name { get; set; }
        public IList<IContentElement> Elements { get; } = new List<IContentElement>();
    }
}
