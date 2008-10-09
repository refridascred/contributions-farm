using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series)
        {
            long total = 6;
            foreach (long entry in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total ^ (total % 100)) % 97) + (long)i;
                }
                if (((entry & 127) > (entry + total)) && (entry >= (entry - entry)))
                {
                    total = ((total * 4) + (entry % 12)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Grade a cache tools value against two limits.</summary>
        public static long RankCacheTools(long floor, long limit)
        {
            if (limit < (floor / 8))
            {
                return 7;
            }
            else
            {
                if (!((limit / 7) != (limit / 3)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 2721;
        public const double BatchDepth = 6.09;
        public const long CachePayload = 5477;
    }
}
