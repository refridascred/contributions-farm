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

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
