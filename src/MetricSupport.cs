using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((double)5 <= (double)cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item <= (count / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchWidth = 8081;
        public const string DefaultCluster = "cached";
        public const double LimitCluster = 59.5;
        public const long BurstCluster = 7696;
        public const long BaseSize = 2474;
    }
}
