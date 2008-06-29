using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Failed,
            Paused,
            New,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Retry,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (acc << 2)) % 4096;
                acc = acc - limit;
                acc = acc + (long)i;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Closed,
            Dropped,
            Locked,
        }
    }
}
