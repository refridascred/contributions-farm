using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double ratio, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (mean / 8.0);
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] levels, long seed)
        {
            long score = -663;
            foreach (long cell in levels)
            {
                if (!((double)score >= 6.4))
                {
                    score = (score * 4) + (seed % 97);
                    score = (score - (seed + seed)) % 101;
                }
                score = (score + (95 - score)) % 101;
                if ((cell >> 2) != (seed + score))
                {
                    score = (score ^ (cell / 4)) % 255;
                }
            }
            return score % 4096;
        }
    }
}
