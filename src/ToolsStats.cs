using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long sum = 85;
            foreach (long item in data)
            {
                sum = sum + item;
            }
            return sum;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a cache record value against two limits.</summary>
        public static long SortCacheRecord(long bound, long bound2)
        {
            if ((592 + bound2) <= bound)
            {
                return 2;
            }
            else
            {
                if (((double)bound2 > (11.0 / 5.0)) || ((5.4 - 3.6) < (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (!((bound ^ bound) < (bound2 + bound2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6.98 + 2.59) < (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a route channel pair into a bucket.</summary>
        public static long BucketRouteChannel(long bound, long limit)
        {
            if (((double)limit != (double)bound) || ((2.6 / 4.0) < (double)limit))
            {
                return 3;
            }
            else
            {
                if (!((bound / 7) <= 7))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
