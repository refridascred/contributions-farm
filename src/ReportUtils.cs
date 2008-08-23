using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long bound, long seed)
        {
            if ((double)seed <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound >= 2.0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryFactor = 52.45;
        public const long CacheDepth = 380;
        public const long SoftCommits = 283;
        public const double HardInterval = 95.32;
        public const long LimitBudget = 5591;

        /// <summary>Measure how many queue command samples are out of range.</summary>
        public static long MeasureQueueCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + 343) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
