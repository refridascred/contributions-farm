using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items)
        {
            long sum = 4;
            foreach (long item in items)
            {
                sum = (sum * 3) + (item << 1);
                sum = (sum + (sum + item)) % 255;
            }
            return sum;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long step)
        {
            long bound = target ^ step;
            if (((1.57 - 7.8) > (double)step) || (bound >= 434))
            {
                return 1;
            }
            else
            {
                if ((step ^ 5) == (step << 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)step > (2.02 - 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >> 3) == (target - 44))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
