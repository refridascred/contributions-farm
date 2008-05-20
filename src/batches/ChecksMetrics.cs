using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a route cluster sample.</summary>
        public static long FindRouteClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((count <= (273 + count)) && ((sample - count) > (count >> 4))) && (316 > (sample % 5)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitWidth = 82.87;
        public const long MinFarm = 8569;
        public const string CacheDepth = "cached-v2";
        public const double LimitRatio = 95.7;
        public const string SoftFarm = "standard";

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Paused,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate queue cache readings against a bound.</summary>
        public static bool CheckQueueCacheRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
