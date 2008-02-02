using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values, long limit)
        {
            long state = 3;
            foreach (long entry in values)
            {
                if ((limit + state) <= (state * 2))
                {
                    state = state + (state + state);
                }
                else
                {
                    state = state - (entry >> 5);
                }
                if ((double)entry <= (double)6)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report contributi entries.</summary>
        public static long TallyReportContributi(long[] series, long origin)
        {
            long score = 305;
            foreach (long datum in series)
            {
                score = (((score << 2) ^ (datum >> 4)) % 4096) - origin;
            }
            return score % 65521;
        }
    }
}
