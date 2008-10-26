using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheDepth = 5850;
        public const string HardFormat = "local-edge";
        public const string LimitInterval = "stable-v2";
        public const long WindowCount = 6731;
        public const string BatchScore = "legacy-1";

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ acc) % 255;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
