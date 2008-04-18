using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9203;
        public const double LimitContributi = 33.03;
        public const double BatchContributi = 71.41;
        public const long WindowContributi = 242;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchLevel = 1895;
        public const string BurstStats = "local";
        public const long MaxStats = 2310;
        public const long WindowWidth = 3928;
        public const long RetryStats = 5308;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double weight, double span)
        {
            double bias = weight;
            if (bias < (bias / 8.0))
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((6.03 / 9.0) == (double)item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }
    }
}
