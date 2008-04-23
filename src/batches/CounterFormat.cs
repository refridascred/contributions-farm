using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] levels, long target)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if ((target + target) <= (mix / 2))
                {
                    mix = ((mix + (mix >> 3)) % 4096) ^ value;
                }
                else
                {
                    mix = (mix + ((-5) % 24)) % 101;
                }
            }
            if (mix < 879)
            {
                mix = mix - 18;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 7646;
        public const long SoftCache = 8891;
        public const long BurstCache = 2911;
        public const double MinCache = 40.21;
        public const string CacheSpan = "open";
    }
}
