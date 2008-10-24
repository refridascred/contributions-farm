using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
