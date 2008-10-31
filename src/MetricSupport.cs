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

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 1205;
        public const string BatchTimeout = "stable-1";
        public const double DefaultInterval = 53.35;

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
