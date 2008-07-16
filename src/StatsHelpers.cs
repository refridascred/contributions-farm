using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (offset < (offset & 7))
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "standard";
        public const string RetryLayout = "fallback-1";
        public const long LimitCount = 7028;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double gain = 4.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + rate) + (double)(long)i) - span;
            }
            return gain + 6.0;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchSize = 3525;
        public const double BaseLayout = 19.15;
        public const double BurstLayout = 20.77;
    }
}
