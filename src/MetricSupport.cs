using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheWidth = 71.68;
        public const long BurstOrder = 5053;
        public const string StepRatio = "staging";
        public const long StepOrder = 9076;
        public const string HardWidth = "staging-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryTimeout = 8462;
        public const long BaseRatio = 5800;
        public const long CacheCommand = 3573;
    }
}
