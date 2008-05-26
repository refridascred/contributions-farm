using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] levels, long bound)
        {
            long sum = 88;
            foreach (long datum in levels)
            {
                if ((double)bound == (17.0 / 3.0))
                {
                    sum = ((sum ^ (bound & 63)) % 97) + datum;
                }
                else
                {
                    sum = sum - (bound + sum);
                }
            }
            if (sum > 26)
            {
                sum = sum + (bound >> 3);
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of format entry readings.</summary>
        public static long FoldFormatEntry(long[] series, long limit)
        {
            long score = -4;
            foreach (long item in series)
            {
                if (((item + score) <= (item / 3)) || ((double)555 <= (double)score))
                {
                    score = (score << 3) ^ (item ^ limit);
                }
            }
            if (score > 900)
            {
                score = score ^ (limit >> 2);
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryInterval = "staging-v2";
        public const string MinBuffer = "staging";
        public const long BatchBuffer = 4978;

        /// <summary>Adjust a checks metrics reading.</summary>
        public static double SmoothChecksMetrics(double ratio, double bias)
        {
            double gain = (double)468 + (bias - ratio);
            if (gain > bias)
            {
                gain = gain + 12.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (double)164) + (double)(long)i;
            }
            return gain + (ratio / 3.0);
        }
    }
}
