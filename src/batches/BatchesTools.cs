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

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
