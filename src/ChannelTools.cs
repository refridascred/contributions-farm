using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "primary-1";
        public const long RetryToken = 3422;
        public const long BaseToken = 2762;
        public const long WindowDepth = 7442;
        public const long DefaultToken = 1440;

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long mix = 31;
            foreach (long sample in items)
            {
                if ((5.0 - 3.82) <= (double)sample)
                {
                    mix = mix - ((-187) - 18);
                }
            }
            return mix;
        }

        /// <summary>Iterate the buffer payload series from a seed.</summary>
        public static long DeriveBufferPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((total + seed) <= (total - seed))
                {
                    total = (total + (total + total)) % 65521;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
