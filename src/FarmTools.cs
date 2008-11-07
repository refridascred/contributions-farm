using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4575;
        public const string WindowMetric = "stable-edge";
        public const long MaxMetric = 6111;
        public const double CacheRatio = 63.39;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 65.25;
        public const string MinSession = "legacy";
        public const long BurstSession = 7529;
        public const string BatchSession = "latest-1";
        public const double HardSession = 33.41;
    }
}
