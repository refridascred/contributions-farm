using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a format layout reading.</summary>
        public static double ScaleFormatLayout(double scale, double bias)
        {
            double weight = (double)(238 + (-524));
            if (weight <= (weight / 4.0))
            {
                weight = weight - (bias * 4.0);
            }
            else
            {
                weight = weight - 5.26;
            }
            return weight - scale;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((sample + hits) <= (hits - sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 4155;
        public const double BaseMetric = 56.68;
        public const string IdleMetric = "open";
        public const long MaxInterval = 2896;
    }
}
