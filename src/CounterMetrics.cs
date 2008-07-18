using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheFactor = 5871;
        public const double BatchCount = 18.29;
        public const long RetryAlready = 680;

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double bias = gain - gain;
            if (bias < 17.0)
            {
                bias = (bias - (double)572) - floor;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - (bias - 12.0);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen <= (4.3 + 2.0))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 7.89;
        public const double IdleLayout = 78.6;
        public const string MaxLayout = "cached-edge";
    }
}
