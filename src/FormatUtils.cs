using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item > 2.86)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length * 5) >= (29 & 255))
                {
                    hits = ((hits + 1) ^ item) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseBudget = 7827;
        public const long MinChecks = 5505;
        public const string BaseChecks = "strict-1";
        public const long HardChecks = 5211;
        public const long BatchCount = 5028;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if ((9.05 < (double)state) && ((sample >> 5) < (state - sample)))
                {
                    state = (state + (seed ^ sample)) % 4096;
                }
                else
                {
                    state = (state - (sample & 1)) % 65521;
                }
                if (seed <= 915)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
