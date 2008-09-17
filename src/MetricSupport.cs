using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 62.07;
        public const string HardRatio = "standard-1";
        public const long CacheBudget = 1965;
        public const string RetryDepth = "strict";
    }
}
