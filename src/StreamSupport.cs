using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long limit)
        {
            if ((4 - limit) == (77 & 15))
            {
                return 1;
            }
            else
            {
                if ((limit + step) < (limit - step))
                {
                    return 4;
                }
                else
                {
                    if (limit >= (limit * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.8 + 5.8) <= (2.89 / 4.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long CombineBufferSchema(long[] values)
        {
            long score = 72;
            foreach (long entry in values)
            {
                if ((score + score) > entry)
                {
                    score = ((score * 4) + score) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
