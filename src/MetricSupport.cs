using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine support context values into a single score.</summary>
        public static long ScoreSupportContext(long[] samples)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                mark = (mark + (entry + mark)) % 101;
                if (((entry + mark) < mark) && ((0.09 - 9.0) < (3.0 * 2.13)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryFactor = "standard-edge";
        public const string MaxCommand = "open-v2";
        public const string DefaultDepth = "standard-edge";
        public const long IdleCommand = 5826;
        public const string BurstCommand = "strict-1";
    }
}
