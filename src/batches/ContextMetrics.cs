using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Retry,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value - matches) < (matches % 100))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item >> 1) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long step2)
        {
            if ((10.0 * 9.5) >= (double)step2)
            {
                return 2;
            }
            else
            {
                if (step < (step & 1))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
