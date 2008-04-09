using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Done,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 70.75;
        public const long BurstBuffer = 1705;
        public const long BurstInterval = 1932;
        public const long BurstRatio = 9542;
    }
}
