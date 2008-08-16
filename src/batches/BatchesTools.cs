using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate stats record readings against a bound.</summary>
        public static bool CheckStatsRecordLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long offset)
        {
            long score = 5;
            foreach (long item in series)
            {
                if ((score > offset) || ((double)item == (16.0 * 6.4)))
                {
                    score = score + 87;
                }
                if ((score + (-6)) <= (offset - item))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
