using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 1974;
        public const long DefaultProfile = 9762;
        public const long SoftProfile = 8627;
        public const long BatchProfile = 3996;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Ready,
            New,
            Pending,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Active,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
