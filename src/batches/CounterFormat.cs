using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinBudget = "strict-v2";
        public const long MinInterval = 2484;
        public const long BatchCount = 6362;
        public const string BaseGraph = "strict-v2";

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (double)130)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
