using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                score = (((score * 3) + (long)levels.Length) % 65521) - cell;
            }
            if (score < (-564))
            {
                score = (score << 3) ^ (score << 3);
            }
            return score;
        }
    }
}
