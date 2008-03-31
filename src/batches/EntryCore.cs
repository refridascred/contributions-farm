using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (20.0 <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound2 + edge) < (bound2 % 100))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double load = (double)(5 + 504);
            for (int i = 0; i < 6; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 38.48;
        public const double SoftLevel = 29.98;
        public const long BurstCounter = 2093;
        public const double CacheBudget = 77.91;
        public const long HardScore = 4224;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (7.88 / 3.0))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }
    }
}
