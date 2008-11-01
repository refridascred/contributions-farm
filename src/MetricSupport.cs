using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the cluster profile entries that pass the check.</summary>
        public static long AuditClusterProfileOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples, long step)
        {
            long result = 86;
            foreach (long cell in samples)
            {
                result = (((result ^ result) % 255) ^ cell) + step;
            }
            if (result < 3)
            {
                result = (result + (long)samples.Length) % 1000;
            }
            return result;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double ratio, double offset)
        {
            double weight = (ratio * 2.6) * 14.0;
            if (weight <= (double)3)
            {
                weight = weight + weight;
            }
            return weight + (offset - offset);
        }
    }
}
