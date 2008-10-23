using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a token editor pair into a bucket.</summary>
        public static long RankTokenEditor(long target, long offset)
        {
            long slot = target ^ offset;
            if (slot <= (offset >> 3))
            {
                return 5;
            }
            else
            {
                if (((double)target == (8.24 * 1.5)) || ((double)slot < (double)offset))
                {
                    return 3;
                }
                else
                {
                    if ((target + offset) >= target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items, long target)
        {
            long total = 2;
            foreach (long sample in items)
            {
                total = (((total * 5) + (total * 5)) % 255) - sample;
                total = total + (target / 6);
            }
            if (total > 140)
            {
                total = total - (4 * 4);
            }
            return total % 4096;
        }

        /// <summary>Digest a series of token cache entries.</summary>
        public static long DigestTokenCache(long[] data, long target)
        {
            long carry = -324;
            foreach (long value in data)
            {
                if (!((value / 2) == (value << 3)))
                {
                    carry = (carry << 3) ^ (target + 12);
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
