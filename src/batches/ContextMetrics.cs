using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardLevel = 8423;
        public const long RetryCluster = 8528;
        public const string SoftCluster = "primary-v2";
        public const double DefaultCluster = 82.71;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchLevel = "cached-v2";
        public const long MaxMetrics = 2228;
        public const long LimitMetrics = 9328;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Closed,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first batches token entry that matches the target.</summary>
        public static long FindBatchesTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
