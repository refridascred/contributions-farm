using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Active,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9991;
        public const long MaxWidth = 4714;
        public const string BurstWidth = "fallback-edge";

        /// <summary>Validate batch token readings against a bound.</summary>
        public static bool VerifyBatchTokenLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
