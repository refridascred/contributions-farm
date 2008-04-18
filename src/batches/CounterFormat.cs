using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double WindowDepth = 67.68;
        public const double BurstTimeout = 43.07;
        public const long CacheToken = 6276;
        public const long MaxToken = 4105;

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!((6.93 + 3.1) <= (double)bound))
                {
                    mix = ((mix << 2) ^ (mix ^ bound)) % 4096;
                }
                if (((bound / 5) > (bound + 6)) || ((mix ^ (long)i) != (5 << 1)))
                {
                    long slot = (7 - 5) + 39;
                    mix = (mix ^ (slot % 5)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
