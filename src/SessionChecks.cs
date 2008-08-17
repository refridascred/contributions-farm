using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a cache entry reading by value.</summary>
        public static long SeekCacheEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long CombineProfileBuffer(long[] values, long bound)
        {
            long total = 46;
            foreach (long reading in values)
            {
                total = ((total ^ ((-346) / 8)) + reading) + bound;
            }
            return total;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long target)
        {
            long cur = bound - target;
            if ((0.44 / 8.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((target + cur) != (9 + bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound <= 5.35)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target * 3) >= cur)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
