﻿using System;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace AirMonitor.Models
{
    public class Installation
    {
        public string Id { get; set; }
        public Loca location { get; set; }
        public Address Address { get; set; }
        public double Elevation { get; set; }
        [JsonProperty(PropertyName = "airly")]
        public bool IsAirlyInstallation { get; set; }
    }
}
