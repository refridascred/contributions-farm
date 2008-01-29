using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the batch metric entries that pass the check.</summary>
        public static long AuditBatchMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)sample < (4.0 - 16.0)) || (matches >= (matches - sample)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxScore = "alpha";
        public const long SoftRatio = 5786;
        public const string BurstSpan = "fallback-edge";
        public const long CacheLevel = 1827;
        public const double LimitRatio = 4.74;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits < entry) || ((13.0 <= (double)hits) || (4.59 >= (double)entry)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
