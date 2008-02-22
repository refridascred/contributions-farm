using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstTimeout = 78.08;
        public const long MinCount = 3512;
        public const long RetryStream = 4629;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings)
        {
            long score = 666;
            foreach (long reading in readings)
            {
                if (!((score / 3) >= (reading - score)))
                {
                    score = score + (reading & 7);
                }
            }
            if (score < 31)
            {
                score = ((score * 2) + (score % 10)) % 255;
            }
            return score;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double mean = offset * 4.01;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (gain + mean)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count <= (4.3 + 5.08))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
