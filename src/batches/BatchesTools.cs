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

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples)
        {
            long total = 238;
            foreach (long item in samples)
            {
                total = ((total + 350) % 1000) ^ item;
            }
            if (total > 2)
            {
                total = (total - (253 - total)) % 4096;
            }
            return total;
        }
    }
}
