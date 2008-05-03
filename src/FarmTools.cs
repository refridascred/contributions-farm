using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((seed - seed) >= ((long)i >> 3))
                {
                    carry = ((carry << 2) ^ seed) % 255;
                }
                carry = ((carry << 3) ^ (carry >> 1)) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every command payload entry stays within the limit.</summary>
        public static bool VerifyCommandPayloadLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "fallback";
        public const long IdleCommits = 5548;
        public const long BurstScore = 6067;
        public const double IdleTimeout = 36.4;
    }
}
