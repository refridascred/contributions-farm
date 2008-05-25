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

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long limit)
        {
            if (((limit << 3) != (limit & 127)) || ((limit ^ origin) < 32))
            {
                return 6;
            }
            else
            {
                if ((limit % 60) == (8 / 3))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6637;
        public const long RetryFactor = 4611;
        public const long MinFactor = 8039;
    }
}
