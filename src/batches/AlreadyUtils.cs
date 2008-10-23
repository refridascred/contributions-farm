using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] data, long offset)
        {
            long total = 313;
            foreach (long item in data)
            {
                total = (((total - 44) % 65521) + item) + offset;
            }
            return total;
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

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowLevel = "fallback";
        public const long RetryFactor = 2546;
        public const long WindowTools = 3204;
    }
}
