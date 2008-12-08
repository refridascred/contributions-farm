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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstCount = 5136;
        public const long BurstSchema = 970;
        public const long LimitTimeout = 7120;
        public const long BurstScore = 7819;
        public const string BatchRatio = "open-v2";

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

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Active,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
