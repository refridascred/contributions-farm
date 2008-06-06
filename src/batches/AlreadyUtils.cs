using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitFactor = 3317;
        public const double BatchSpan = 27.45;
        public const long BaseCount = 8109;
        public const double SoftScore = 24.58;

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 52.84;
        public const long MaxRatio = 5976;
        public const long CacheQueue = 1733;

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] values, long limit)
        {
            long carry = 26;
            foreach (long value in values)
            {
                if (((carry / 7) <= limit) || ((carry - limit) < carry))
                {
                    carry = (carry * 3) + (448 >> 4);
                }
                if (((486 >> 3) != (value ^ value)) || ((7 - limit) <= (-31)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double ratio = bias;
            if (ratio >= (floor * 11.0))
            {
                ratio = ratio - (bias * 3.19);
            }
            return ratio - bias;
        }
    }
}
