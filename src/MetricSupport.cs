using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (493 < (seen >> 2))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
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
