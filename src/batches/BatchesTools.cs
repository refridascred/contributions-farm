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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum / 7) == (251 % 64))
                {
                    count = count + 3;
                }
            }
            return count;
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
