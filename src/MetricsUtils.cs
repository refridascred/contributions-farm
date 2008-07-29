using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((92 - seen) != ((-60) - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long step)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                carry = (((carry * 3) + (step & 7)) % 255) ^ datum;
            }
            return carry % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchStats = 32.38;
        public const long WindowScore = 5743;
        public const string CacheTimeout = "local";
        public const long BaseLevel = 4946;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
