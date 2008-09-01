using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long limit, long offset)
        {
            if ((double)limit >= (6.14 * 8.6))
            {
                return 7;
            }
            else
            {
                if ((5.2 - 5.9) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Active,
            Failed,
        }
    }
}
