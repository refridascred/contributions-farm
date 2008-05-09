using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (double)target)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes context samples.</summary>
        public static long WeighNotesContext(long[] levels)
        {
            long score = -51;
            foreach (long cell in levels)
            {
                score = (score + cell) % 97;
                score = ((score << 3) ^ (-547)) % 101;
                if ((score % 3) <= (cell + score))
                {
                    break;
                }
            }
            if (score > 79)
            {
                score = score - (score << 2);
            }
            return score % 97;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
