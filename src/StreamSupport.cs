using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            Idle,
            Done,
            Paused,
            Active,
        }

        /// <summary>Measure how many stats metrics samples are out of range.</summary>
        public static long MeasureStatsMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((double)item <= (19.0 / 3.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] series)
        {
            long sum = 7;
            foreach (long item in series)
            {
                sum = sum - item;
            }
            if (sum > 27)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }
    }
}
