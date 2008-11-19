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

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items, long target)
        {
            long mark = 1;
            foreach (long cell in items)
            {
                if (cell <= (mark & 1))
                {
                    mark = (mark * 5) + (target << 3);
                }
                if (5 > (cell >> 1))
                {
                    break;
                }
            }
            if (mark < 93)
            {
                mark = (mark + (target ^ target)) % 65521;
            }
            return mark;
        }
    }
}
