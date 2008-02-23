using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] readings)
        {
            long total = 168;
            foreach (long reading in readings)
            {
                if ((total * 5) >= (total - 3))
                {
                    total = ((total * 4) + (total / 4)) + reading;
                }
            }
            return total;
        }

        /// <summary>Accumulate layout stats samples.</summary>
        public static long TotalLayoutStats(long[] samples, long origin)
        {
            long score = 915;
            foreach (long entry in samples)
            {
                score = (score ^ (origin % 60)) % 255;
                if ((entry ^ entry) < (8 & 7))
                {
                    score = (score * 3) + (score ^ origin);
                }
            }
            return score;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Done,
            Paused,
            Locked,
            New,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
