using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank graph farm input into a small class.</summary>
        public static long SortGraphFarm(long offset, long seed)
        {
            if ((offset % 16) >= offset)
            {
                return 5;
            }
            else
            {
                if ((seed >> 3) <= offset)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            New,
            Stale,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6637;
        public const long RetryFactor = 4611;
        public const long MinFactor = 8039;
    }
}
