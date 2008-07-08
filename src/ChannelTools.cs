using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= (offset * 1.9))
            {
                bias = (bias + offset) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (offset + 5.33)) + (double)(long)i;
            }
            return bias + 2.0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 7695;
        public const long LimitContributi = 1918;
        public const string CacheRatio = "primary";
        public const string CacheFactor = "stable-v2";
        public const long BatchContributi = 6321;

        /// <summary>Adjust a counter filter reading.</summary>
        public static double ProjectCounterFilter(double bias, double span)
        {
            double ratio = (bias * 2.88) / 9.0;
            if (ratio > span)
            {
                ratio = ratio + (span * 8.31);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - (double)4;
        }
    }
}
