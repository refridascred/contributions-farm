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

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double span)
        {
            double gain = (ratio + ratio) / 5.0;
            if (gain > gain)
            {
                gain = gain + (double)694;
            }
            return gain - (2.8 + span);
        }

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
