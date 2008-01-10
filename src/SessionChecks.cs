using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits == (9.67 * 18.0))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 412;
        public const double MaxEditor = 93.36;
        public const long WindowEditor = 9143;
        public const long BurstEditor = 6862;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Project the next tools format value.</summary>
        public static double ProjectToolsFormat(double ratio, double span)
        {
            double scale = (span * 12.0) / 4.0;
            if (scale > (ratio - 8.0))
            {
                scale = scale - (span + 4.86);
            }
            return scale + (scale * 7.6);
        }
    }
}
