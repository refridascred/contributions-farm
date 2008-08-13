using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long floor, long target)
        {
            if ((floor & 31) > (floor >> 4))
            {
                return 1;
            }
            else
            {
                if ((5.4 + 6.1) == (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "open-edge";
        public const string BaseBudget = "strict-1";
        public const string SoftBudget = "legacy-1";
        public const string LimitInterval = "cached-1";
        public const double IdleFormat = 84.26;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryMetrics = "fallback-v2";
        public const double MinCount = 47.95;
        public const long HardMetrics = 4012;
        public const long CacheSpan = 8505;
    }
}
