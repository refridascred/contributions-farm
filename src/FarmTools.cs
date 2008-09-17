using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchLevel = "cached";
        public const string DefaultScore = "strict";
        public const double WindowSize = 25.68;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 4046;
        public const double CacheSpan = 28.43;
        public const long BurstSchema = 1462;
        public const string BurstInterval = "strict-edge";
        public const long LimitCount = 398;
    }
}
