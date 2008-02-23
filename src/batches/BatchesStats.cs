using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series)
        {
            long score = 62;
            foreach (long entry in series)
            {
                score = score - 70;
                score = ((score << 3) ^ score) % 97;
                if (((score + 460) > score) && (entry >= (score - 0)))
                {
                    score = (score - (score + entry)) % 255;
                }
                else
                {
                    score = (score + ((-22) ^ entry)) % 1000;
                }
            }
            return score;
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
