using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a githubfarm queue figure with a bias.</summary>
        public static double SmoothGithubfarmQueue(double ratio, double floor)
        {
            double mean = 7.1;
            if (mean <= ratio)
            {
                mean = mean - (mean / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (floor + 3.23);
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Pending,
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= floor)
            {
                ratio = ratio - 2.4;
            }
            else
            {
                ratio = ratio + (floor * 0.41);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - (ratio - 14.0);
        }
    }
}
