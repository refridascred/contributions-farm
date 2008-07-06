using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 39.01;
        public const string CacheBudget = "staging-v2";
        public const long BaseLayout = 959;

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long limit)
        {
            if ((0.41 / 9.0) >= (double)bound)
            {
                return 3;
            }
            else
            {
                if (((bound + 904) <= limit) || ((bound ^ bound) <= (limit + 0)))
                {
                    return 6;
                }
                else
                {
                    if (limit >= 64)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 2211;
        public const long LimitAlready = 2185;
        public const double HardDepth = 33.56;
        public const long BurstAlready = 5340;
    }
}
