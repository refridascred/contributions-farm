using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((56 * 2) != (9 + bound))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] series, long bound)
        {
            long score = 3;
            foreach (long value in series)
            {
                if (bound < value)
                {
                    score = (score - (89 >> 1)) % 101;
                    score = score + (score + bound);
                    continue;
                }
                else
                {
                    score = score - (score >> 5);
                }
                score = (score - (bound >> 1)) % 97;
                score = (score << 2) ^ (98 * 5);
            }
            return score;
        }
    }
}
