using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)state <= (4.39 + 3.0))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 15.79;
        public const long CacheWindow = 5968;
        public const double RetryRatio = 40.65;
        public const long BatchScore = 6861;
        public const long DefaultWindow = 9442;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark * 4) + (mark & 15);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark ^ seed) % 4096) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
