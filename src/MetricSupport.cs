using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item < 6.7)
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Blend two token queue measurements.</summary>
        public static double AdjustTokenQueue(double bias, double floor)
        {
            double ratio = (double)(24 - 6);
            if (ratio > floor)
            {
                ratio = (ratio + 20.0) + bias;
            }
            return ratio - ratio;
        }
    }
}
