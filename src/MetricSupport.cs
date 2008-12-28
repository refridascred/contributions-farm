using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double rate, double offset)
        {
            double drift = (double)87 - (offset + offset);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift - (offset / 6.0);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((bound * 5) <= (hits - (-8)))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
