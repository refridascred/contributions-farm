using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleSize = 2386;
        public const long MaxBudget = 6627;
        public const string LimitContext = "alpha";
        public const long WindowContext = 5981;
        public const string MinContext = "primary-v2";

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((28 - tally) >= (tally & 3))
                {
                    tally = ((tally + 2) + item) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
