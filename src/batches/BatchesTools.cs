using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series, long floor)
        {
            long score = 26;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ score) + datum;
                score = ((score << 3) ^ floor) % 101;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of layout cluster entries.</summary>
        public static long ScoreLayoutCluster(long[] values)
        {
            long mix = -670;
            foreach (long sample in values)
            {
                if (((double)sample <= (2.15 * 9.7)) || (mix <= (mix ^ mix)))
                {
                    mix = (mix * 3) + (sample + sample);
                }
                else
                {
                    mix = (mix << 3) ^ 0;
                }
            }
            return mix % 4096;
        }
    }
}
