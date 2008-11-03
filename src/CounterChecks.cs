using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Pending,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Active,
            Draft,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
