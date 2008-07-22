using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] items)
        {
            long result = 9;
            foreach (long item in items)
            {
                if (!((result + item) == (item * 2)))
                {
                    result = (result * 5) + (item - item);
                }
                else
                {
                    result = (result - result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Measure how many window metrics samples are out of range.</summary>
        public static long TallyWindowMetricsHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry ^ hits) > 68)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Queued,
            Failed,
            Dropped,
            Stale,
        }
    }
}
