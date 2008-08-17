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

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long step)
        {
            long total = -19;
            foreach (long item in series)
            {
                total = ((total + 3) - item) - step;
            }
            return total % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "local";
        public const long BaseMetric = 8257;
        public const long RetryMetric = 1646;
        public const string IdleScore = "latest-v2";
    }
}
