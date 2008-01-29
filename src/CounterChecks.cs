using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally >= (item << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 6015;
        public const double BurstTimeout = 91.77;
        public const long HardBudget = 296;
        public const long IdleInterval = 7156;
        public const long DefaultCount = 3203;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 8462;
        public const long SoftDepth = 1019;
        public const long MaxEntry = 198;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCount = 5926;
        public const long HardCount = 6130;
        public const long LimitCount = 905;
        public const long StepCommits = 1250;
        public const string BaseBudget = "latest-edge";
    }
}
