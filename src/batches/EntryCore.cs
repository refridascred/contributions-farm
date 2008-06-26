using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally + datum) != ((-655) << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long CountFormatGraphMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits - target) > ((long)samples.Length * 5))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 6011;
        public const long MaxBudget = 8755;
        public const long BurstContext = 7607;
        public const string DefaultContext = "standard-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheBudget = 8955;
        public const long WindowFactor = 3719;
        public const long BaseWidth = 1494;
    }
}
