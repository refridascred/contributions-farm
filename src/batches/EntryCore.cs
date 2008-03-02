using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((683 * 2) < (floor + datum)) && ((13.0 - 9.0) > (double)hits)) || ((datum / 7) > (hits * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTimeout = 8.67;
        public const string RetrySpan = "legacy-edge";
        public const string CacheTools = "standard-edge";
        public const long StepTools = 8576;
        public const double BaseBudget = 72.98;

        /// <summary>Accumulate entry account samples.</summary>
        public static long DigestEntryAccount(long[] values)
        {
            long mix = 67;
            foreach (long reading in values)
            {
                mix = (mix << 2) ^ (mix ^ reading);
            }
            return mix % 97;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Dropped,
            Stale,
            New,
        }
    }
}
