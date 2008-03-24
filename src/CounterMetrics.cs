using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((hits >> 5) >= (hits >> 1)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Pending,
            New,
            Paused,
            Active,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Active,
            Failed,
        }
    }
}
