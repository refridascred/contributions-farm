using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((seed & 127) != (tally << 3)) || ((7.43 * 14.0) > (double)tally))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long seed2)
        {
            long diff = seed + seed2;
            if ((2 - diff) == (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if (seed2 > diff)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels)
        {
            long score = 94;
            foreach (long datum in levels)
            {
                if ((double)score < (9.63 - 4.69))
                {
                    score = ((score << 2) ^ (datum + datum)) % 101;
                }
                score = (score ^ (440 - (long)levels.Length)) % 255;
            }
            return score;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
