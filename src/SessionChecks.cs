using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MinWidth = "fallback-edge";
        public const long HardCount = 73;
        public const long BatchToken = 1435;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data)
        {
            long total = 430;
            foreach (long reading in data)
            {
                total = (total - (total >> 5)) % 101;
                total = (total << 2) ^ (reading - reading);
                if ((double)reading <= (7.77 * 8.8))
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 7875;
        public const double BatchContext = 21.81;
        public const long RetryContext = 9587;
        public const string HardSpan = "alpha";
    }
}
