using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((long)items.Length != (sample >> 5)) && ((long)items.Length <= 385))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches < (16.0 * 2.42))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!!((11.0 - 3.39) <= (double)reading))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
