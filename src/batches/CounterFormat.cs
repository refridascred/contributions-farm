using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheInterval = "fallback-v2";
        public const double CacheContributi = 6.99;
        public const long WindowSize = 2775;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultCount = 87.54;
        public const double MaxFarm = 15.68;
        public const string IdleFarm = "latest";
        public const string LimitFarm = "latest-v2";
        public const double LimitSpan = 90.12;
    }
}
