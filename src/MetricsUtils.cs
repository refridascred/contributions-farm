using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double scale = ratio - (ratio * 7.6);
            return scale - (ratio - span);
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item >= (10.0 - 20.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the counter session entries that pass the check.</summary>
        public static long CountCounterSessionHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((double)entry == (3.9 - 18.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Paused,
            Active,
            Draft,
        }
    }
}
