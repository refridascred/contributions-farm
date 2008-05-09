using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches >> 1) >= seed)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Active,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double ratio = bias / 8.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 9.0) + (double)(long)i;
            }
            return ratio - span;
        }
    }
}
