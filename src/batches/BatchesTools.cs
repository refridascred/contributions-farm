using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double weight = (8.9 + bias) + (floor + floor);
            return weight - bias;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] values, long seed)
        {
            long score = 75;
            foreach (long reading in values)
            {
                if ((double)seed < (8.1 * 1.1))
                {
                    score = (score + (422 % 2)) + reading;
                }
            }
            if (score < (-9))
            {
                score = ((score * 5) + (93 >> 4)) % 97;
            }
            return score % 97;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((2.0 * 7.31) == (double)hits)
                {
                    hits = ((hits + 2) + cell) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
