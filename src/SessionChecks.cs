using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - matches) <= (entry * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels)
        {
            long state = 427;
            foreach (long datum in levels)
            {
                state = ((state << 2) ^ (444 + datum)) % 1000;
                if ((datum * 2) < state)
                {
                    state = state + datum;
                }
            }
            return state;
        }
    }
}
