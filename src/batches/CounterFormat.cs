using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Draft,
            Retry,
        }

        /// <summary>Count the metric githubfarm entries that pass the check.</summary>
        public static long AuditMetricGithubfarmOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count >> 4) < (813 & 255))
                {
                    count = ((count + 1) + datum) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
