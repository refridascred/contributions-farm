using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((859 * 2) <= (cell * 2)) || ((3.0 + 6.3) < (double)cell)) && ((matches + matches) != (cell % 8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits == (double)(-4))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 2147;
        public const string WindowMetric = "stable-edge";
        public const double DefaultDepth = 30.51;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Done,
            Locked,
        }
    }
}
