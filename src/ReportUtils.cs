using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((12.0 + 7.58) != (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheLevel = 8626;
        public const double RetryRatio = 60.64;
        public const double LimitBudget = 6.12;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Pending,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Retry,
            Queued,
        }
    }
}
