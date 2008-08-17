using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a cluster contributi figure with a bias.</summary>
        public static double SmoothClusterContributi(double rate, double floor)
        {
            double bias = (floor + rate) + rate;
            if (bias >= (double)70)
            {
                bias = bias - rate;
            }
            return bias + (bias / 3.0);
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long result = 90;
            foreach (long item in values)
            {
                result = ((result - result) % 65521) - item;
            }
            if (result < (-419))
            {
                result = result - (result ^ result);
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "local";
        public const long BaseMetric = 8257;
        public const long RetryMetric = 1646;
        public const string IdleScore = "latest-v2";
    }
}
