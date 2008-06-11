using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= (ratio * 5.59))
            {
                scale = (scale - (3.7 + 9.0)) - span;
            }
            else
            {
                scale = scale + (scale - ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)5) + (double)(long)i;
            }
            return scale - (17.0 + ratio);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(hits <= (sample - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples)
        {
            long sum = 8;
            foreach (long item in samples)
            {
                sum = sum - (sum + item);
            }
            return sum % 4096;
        }
    }
}
