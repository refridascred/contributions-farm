using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the window report entries that pass the check.</summary>
        public static long TallyWindowReportOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) > entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            New,
            Dropped,
            Retry,
            Stale,
        }
    }
}
