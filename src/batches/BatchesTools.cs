using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + count) >= 49)
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 1110;
        public const long StepTools = 7374;
        public const double DefaultTools = 61.65;
        public const long DefaultSize = 6258;
        public const string WindowSize = "fallback-1";

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double gain, double floor)
        {
            double weight = (double)(87 * 5);
            if (weight > floor)
            {
                weight = weight + (floor - gain);
            }
            else
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 3.3) + (double)(long)i;
            }
            return weight + (floor * 7.94);
        }
    }
}
