using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1058;
        public const string IdleSpan = "stable-v2";
        public const string HardLevel = "latest-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheCount = 78.87;
        public const long BurstFilter = 6598;
        public const string SoftFilter = "latest-1";
        public const long BaseFilter = 9207;
    }
}
