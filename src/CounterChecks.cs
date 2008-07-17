using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Ready,
            Failed,
            Pending,
            Synced,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (0.29 + 2.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
