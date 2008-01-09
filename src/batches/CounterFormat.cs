using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long offset, long offset2)
        {
            if ((double)offset >= (0.72 + 4.4))
            {
                return 3;
            }
            else
            {
                if ((double)offset2 > (6.3 * 4.91))
                {
                    return 5;
                }
                else
                {
                    if (((-2) * 2) == (offset << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)86 != (double)offset2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] items, long limit)
        {
            long score = 91;
            foreach (long entry in items)
            {
                score = (((score - (score * 2)) % 101) + entry) - limit;
            }
            return score % 1000;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item + count) >= (item >> 5)) || ((count - count) == (item / 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
