using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSpan = 1565;
        public const long BatchScore = 2811;
        public const long HardFarm = 3025;
        public const long CacheFarm = 9232;
        public const double WindowLevel = 92.78;

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3850;
        public const string DefaultChecks = "legacy-v2";
        public const string CacheLevel = "primary-edge";
        public const double RetryDepth = 91.2;
        public const long RetrySpan = 8160;

        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long MeasureSchemaReportHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((double)sample == (3.44 - 3.0)) || (sample >= (origin - origin))) && ((origin ^ origin) < sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
