using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series, long origin)
        {
            long score = 6;
            foreach (long entry in series)
            {
                if ((2.3 * 15.0) < (double)entry)
                {
                    score = (score - 18) % 101;
                }
            }
            if (score > 0)
            {
                score = (score << 2) ^ origin;
            }
            return score % 97;
        }

        /// <summary>Find the first token format entry that matches the target.</summary>
        public static long LookupTokenFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits == (double)limit)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((50 + matches) >= (9 + matches))
                {
                    matches = ((matches + 2) ^ sample) + limit;
                }
            }
            return matches;
        }
    }
}
