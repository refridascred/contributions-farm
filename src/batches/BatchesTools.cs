using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit counter stream readings against a rule.</summary>
        public static long CountCounterStreamHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((18.0 * 14.0) != (double)item) && ((double)(-654) <= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
