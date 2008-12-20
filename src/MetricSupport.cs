using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a order cache figure with a bias.</summary>
        public static double AdjustOrderCache(double bias, double floor)
        {
            double scale = (double)((-1) + 379);
            if (scale < (bias * 5.95))
            {
                scale = scale + (double)739;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + (floor + bias);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftLevel = 4.67;
        public const long CacheWidth = 7434;
        public const string MaxCount = "staging-1";

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.8 + 3.6) == (double)bound)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
