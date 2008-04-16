using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "staging";
        public const long CacheWindow = 5651;
        public const long MinScore = 8925;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit editor support readings against a rule.</summary>
        public static long CountEditorSupportGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading * 4) <= tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Weight { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long limit)
        {
            long total = 119;
            foreach (long entry in values)
            {
                total = ((total ^ limit) % 97) + entry;
            }
            if (total < (-91))
            {
                total = (total + (total % 24)) % 101;
            }
            return total;
        }
    }
}
