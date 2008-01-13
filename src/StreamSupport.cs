using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstSize = 2623;
        public const long RetrySpan = 8919;
        public const double SoftCommits = 37.8;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Pending,
            Ready,
            Failed,
            Synced,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double bias = rate;
            if (bias > 8.1)
            {
                bias = (bias - (bias / 2.0)) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (double)(-156);
        }
    }
}
