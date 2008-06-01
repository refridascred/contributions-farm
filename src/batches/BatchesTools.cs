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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
