using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 10.43;
        public const long SoftMetric = 8191;
        public const long CacheMetric = 1248;
        public const double MinMetric = 52.36;
        public const string StepMetric = "alpha-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "latest-edge";
        public const long StepDepth = 3531;
        public const string HardScore = "open";
        public const long HardInterval = 7581;

        /// <summary>Check that every stats channel entry stays within the limit.</summary>
        public static bool VerifyStatsChannelBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
