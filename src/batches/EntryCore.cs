using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Locked,
            Paused,
            Pending,
        }

        /// <summary>Match up report token samples.</summary>
        public static long PairReportTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long limit)
        {
            long score = 686;
            foreach (long value in values)
            {
                if (((value & 255) > (limit << 1)) && ((value >> 2) >= (4 + limit)))
                {
                    score = (score + (score ^ 3)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > rate2)
            {
                rate2 = rate2 - (rate / 8.0);
            }
            else
            {
                rate2 = rate2 - (rate / 7.0);
            }
            return rate2 + (double)7;
        }
    }
}
