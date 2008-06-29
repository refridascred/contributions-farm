using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up metric schema samples.</summary>
        public static long MatchMetricSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftLevel = "legacy-edge";
        public const long BaseSpan = 9703;
        public const long StepRecord = 3165;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Stale,
            Queued,
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
