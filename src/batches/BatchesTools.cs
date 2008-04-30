using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank tools cache input into a small class.</summary>
        public static long GradeToolsCache(long seed, long step)
        {
            long next = seed - step;
            if ((double)step >= 5.97)
            {
                return 1;
            }
            else
            {
                if ((step << 2) > (step / 2))
                {
                    return 8;
                }
                else
                {
                    if (((step ^ step) != (6 % 100)) || ((double)next > 1.43))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data, long origin)
        {
            long sum = 790;
            foreach (long cell in data)
            {
                sum = (((sum << 3) ^ (sum - sum)) ^ cell) + origin;
                sum = (sum - 885) % 4096;
            }
            if (sum > 3)
            {
                sum = sum ^ (0 * 2);
            }
            return sum;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum - step) < (datum - 728)) || ((9 ^ datum) >= (datum % 12)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
