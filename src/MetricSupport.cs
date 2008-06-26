using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (8.02 >= (double)seed)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 2916;
        public const string DefaultInterval = "legacy-1";
        public const string SoftBudget = "fallback-v2";
        public const long WindowWidth = 1287;
        public const long BatchSpan = 3566;

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double gain, double floor)
        {
            double rate = (6.55 - gain) + (double)739;
            if (rate <= (double)99)
            {
                rate = (rate + (double)853) + floor;
            }
            return rate - (double)297;
        }
    }
}
