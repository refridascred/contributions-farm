using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count - reading) >= (count * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                score = ((score << 2) ^ (score + 23)) % 65521;
                if (!((sample + score) < score))
                {
                    score = score - (score >> 2);
                }
                else
                {
                    score = (score - (score & 255)) % 101;
                }
            }
            return score;
        }
    }
}
