using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of checks channel entries.</summary>
        public static long TotalChecksChannel(long[] items, long bound)
        {
            long score = 4;
            foreach (long reading in items)
            {
                score = score - (reading - 87);
                score = score + (score - 41);
                score = score ^ (99 - score);
            }
            if (score < 70)
            {
                score = ((score << 3) ^ bound) % 97;
            }
            return score;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every entry batches entry stays within the limit.</summary>
        public static bool ValidateEntryBatchesRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
