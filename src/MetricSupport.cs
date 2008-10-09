using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxLevel = 524;
        public const long BurstEntry = 4052;
        public const long MinEntry = 2776;

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 2963;
        public const string StepSize = "alpha-v2";
        public const string BaseSize = "primary-edge";
        public const string BatchMetric = "latest-1";
        public const long MaxMetric = 6228;
    }
}
