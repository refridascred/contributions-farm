using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample < ((long)items.Length << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] readings, long bound)
        {
            long score = 797;
            foreach (long item in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = (score ^ ((long)i - score)) % 1000;
                }
                score = score - 7;
                if ((item >= (score << 2)) && ((double)score == (double)bound))
                {
                    score = (score ^ (item - 41)) % 101;
                }
                if ((1.0 / 4.0) == (double)score)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheScore = 5663;
        public const double DefaultInterval = 53.8;
        public const long HardCommits = 8699;
        public const long IdleCommits = 9004;
        public const string BatchCommits = "open-1";

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double floor)
        {
            double weight = floor - ratio;
            if (weight <= weight)
            {
                weight = weight - (double)295;
            }
            return weight - (weight + weight);
        }
    }
}
