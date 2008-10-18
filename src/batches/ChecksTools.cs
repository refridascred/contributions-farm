using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a cache metrics value against two limits.</summary>
        public static long BucketCacheMetrics(long origin, long step)
        {
            if ((step % 12) == (step % 2))
            {
                return 6;
            }
            else
            {
                if ((double)step >= (16.0 - 6.0))
                {
                    return 7;
                }
                else
                {
                    if ((step ^ origin) <= (origin + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count * 4) >= (count % 5))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Retry,
            Dropped,
            New,
            Closed,
        }
    }
}
