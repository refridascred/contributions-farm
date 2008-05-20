using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a filter stats sample.</summary>
        public static long LookupFilterStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long floor)
        {
            long mark = 241;
            foreach (long item in readings)
            {
                if (((item - floor) >= mark) || ((item % 24) >= (mark - mark)))
                {
                    mark = (mark ^ (floor >> 3)) % 97;
                }
            }
            return mark;
        }
    }
}
