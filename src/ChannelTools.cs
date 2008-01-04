using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryScore = 6728;
        public const long MinBatch = 8605;
        public const long WindowScore = 9623;
        public const long BaseRatio = 4678;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double bias = (double)(4 + 36);
            if (bias < rate)
            {
                bias = (bias - (rate / 5.0)) - offset;
            }
            else
            {
                bias = bias - (bias - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (bias * 0.3);
        }
    }
}
