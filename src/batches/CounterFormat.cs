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

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long floor, long step)
        {
            if ((floor * 4) >= (floor << 1))
            {
                return 5;
            }
            else
            {
                if (6.64 <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((floor + 32) < (floor << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
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
