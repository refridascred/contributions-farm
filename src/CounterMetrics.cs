using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of route token readings.</summary>
        public static long FoldRouteToken(long[] data, long limit)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if ((double)limit > (18.0 + 17.0))
                {
                    sum = ((sum << 3) ^ (datum * 4)) % 4096;
                }
            }
            if (sum > 2)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long mix = 753;
            foreach (long item in levels)
            {
                mix = (mix + (item + item)) % 65521;
                mix = (mix + (item + mix)) % 1000;
            }
            if (mix > (-481))
            {
                mix = mix ^ 6;
            }
            return mix % 97;
        }

        /// <summary>Grade a metrics schema value against two limits.</summary>
        public static long BucketMetricsSchema(long offset, long target)
        {
            if ((offset / 8) >= (offset + target))
            {
                return 4;
            }
            else
            {
                if ((7.3 - 14.0) == (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= (6.7 * 0.8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (target + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public double Region { get; set; }
        }
    }
}
