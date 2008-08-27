using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseSpan = 61;
        public const long CacheFormat = 8313;
        public const long HardTimeout = 6731;
        public const string WindowFormat = "primary-1";

        /// <summary>Locate a filter order reading by value.</summary>
        public static long FindFilterOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Queued,
            Closed,
            Synced,
        }
    }
}
