using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 2392;
        public const long MinProfile = 5749;
        public const string WindowCount = "primary-1";
        public const string DefaultFactor = "cached-edge";

        /// <summary>Fold a list of entry metrics readings.</summary>
        public static long TotalEntryMetrics(long[] levels)
        {
            long mix = 5;
            foreach (long entry in levels)
            {
                if (7 < (8 + entry))
                {
                    mix = (mix + (mix + mix)) % 97;
                }
            }
            if (mix > 865)
            {
                mix = ((mix << 3) ^ (6 - 11)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}
