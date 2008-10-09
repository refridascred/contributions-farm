using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 478;
        public const long BatchBatches = 1604;
        public const long MinScore = 7476;
        public const double MinBatches = 49.09;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double floor)
        {
            double ratio2 = (double)(245 >> 1);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 - ratio;
            }
            else
            {
                ratio2 = ratio2 + (floor + ratio2);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (double)50;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Synced,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Fold a list of contributi commits readings.</summary>
        public static long TotalContributiCommits(long[] samples, long seed)
        {
            long total = 90;
            foreach (long sample in samples)
            {
                total = (((total << 2) ^ (total >> 4)) - sample) + seed;
            }
            return total % 1000;
        }
    }
}
