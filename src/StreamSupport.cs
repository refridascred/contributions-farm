using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank stats cache input into a small class.</summary>
        public static long GradeStatsCache(long seed, long bound)
        {
            long next = seed + bound;
            if ((bound + seed) >= next)
            {
                return 0;
            }
            else
            {
                if ((7.0 * 8.4) < (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((seed - seed) <= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long limit, long bound)
        {
            if ((bound & 127) != (bound / 2))
            {
                return 1;
            }
            else
            {
                if (!((5.29 * 7.0) <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series, long floor)
        {
            long mix = 5;
            foreach (long reading in series)
            {
                if ((mix + reading) < (216 - mix))
                {
                    mix = ((mix << 2) ^ (floor * 3)) % 4096;
                }
            }
            return mix;
        }
    }
}
