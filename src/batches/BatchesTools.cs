using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "legacy-1";
        public const long IdleSpan = 5423;
        public const long RetryLevel = 3064;
        public const long BurstWidth = 8100;
        public const long MinMetric = 9404;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
