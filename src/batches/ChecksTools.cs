using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "alpha-v2";
        public const double BaseEntry = 16.37;
        public const double BatchSize = 44.46;
        public const long BatchEntry = 7282;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleSize = 2247;
        public const long IdleWidth = 5205;
        public const long MaxStream = 3001;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long offset, long origin)
        {
            if (((double)origin >= (19.0 / 8.0)) || (3.22 < (double)offset))
            {
                return 8;
            }
            else
            {
                if (origin < (origin + origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
