using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a window cache counter forward.</summary>
        public static long IterateWindowCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long slot = 40;
                    mark = ((mark << 2) ^ (slot + (long)i2)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
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
