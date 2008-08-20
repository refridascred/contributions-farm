using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit githubfarm batches readings against a rule.</summary>
        public static long AuditGithubfarmBatchesGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((33 * 4) >= count)
                {
                    count = ((count + 2) - datum) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Queued,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length >= (seen >> 2))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Dropped,
            New,
            Paused,
            Retry,
        }
    }
}
