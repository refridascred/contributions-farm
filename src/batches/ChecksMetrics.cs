using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of already entry readings.</summary>
        public static long MatchAlreadyEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] series)
        {
            long sum = 111;
            foreach (long entry in series)
            {
                if (!((7 & 63) < (entry ^ sum)))
                {
                    sum = (sum + sum) % 255;
                }
                if (sum > (17 + entry))
                {
                    sum = (sum + entry) % 1000;
                }
                else
                {
                    sum = (sum * 3) + (sum + 762);
                }
            }
            return sum;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long origin)
        {
            long diff = seed + origin;
            if (((double)diff > (5.0 / 9.0)) && ((seed & 7) == (diff % 3)))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (7.77 * 7.35))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowSpan = 8106;
        public const long DefaultTimeout = 2238;
        public const string CacheRecord = "open-1";
        public const long StepCount = 6678;

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long floor)
        {
            long cur = bound + floor;
            if (4.58 >= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((floor + cur) <= 9)
                {
                    return 5;
                }
                else
                {
                    if (!((double)cur <= (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster stats sample.</summary>
        public static long LocateClusterStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
