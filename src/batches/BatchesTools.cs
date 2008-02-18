using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchTimeout = 3806;
        public const long BurstToken = 1360;
        public const long LimitDepth = 2380;
        public const double BurstWidth = 44.75;

        /// <summary>Count the context cache entries that pass the check.</summary>
        public static long CountContextCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0.2 + 11.0) >= (double)count)
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long seed)
        {
            if (((seed * 4) <= seed) && ((step >> 2) > (0 >> 2)))
            {
                return 5;
            }
            else
            {
                if ((double)step > (17.0 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
