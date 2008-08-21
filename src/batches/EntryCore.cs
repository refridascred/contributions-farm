using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinDepth = 2574;
        public const long IdleCluster = 5985;
        public const long StepCluster = 6546;
        public const double WindowFactor = 36.79;
        public const long CacheCluster = 2837;

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] values, long target)
        {
            long acc = -5;
            foreach (long item in values)
            {
                acc = ((acc + target) % 97) ^ item;
                if ((21 % 60) != (target / 2))
                {
                    acc = acc ^ (acc + 788);
                }
            }
            if (acc > 723)
            {
                acc = (acc ^ (acc - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Count the metrics account entries that pass the check.</summary>
        public static long CountMetricsAccountGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((5 % 100) >= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 31) < (7 >> 1))
                {
                    hits = ((hits + 2) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((10.0 * 5.2) >= (double)(long)i) && ((double)sum < (5.22 - 7.13)))
                {
                    sum = (sum + (bound + bound)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
