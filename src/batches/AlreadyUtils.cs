using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a support contributi reading by value.</summary>
        public static long SeekSupportContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleWidth = 3.71;
        public const long BatchFactor = 6158;
        public const string RetryContributi = "staging-edge";
        public const long BaseSize = 1728;

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
