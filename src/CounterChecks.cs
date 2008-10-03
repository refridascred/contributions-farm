using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit tools stream readings against a rule.</summary>
        public static long TallyToolsStreamHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((target - 2) < (datum << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchScore = 3336;
        public const long StepChecks = 8958;
        public const string LimitDepth = "latest";
        public const string BatchChecks = "fallback-1";

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches == (double)entry)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels)
        {
            long acc = 818;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc ^ item) % 97) ^ (long)i;
                }
                if ((23 <= (item + item)) || (((-519) / 9) < (item + acc)))
                {
                    acc = (acc + 0) % 4096;
                }
            }
            return acc;
        }
    }
}
