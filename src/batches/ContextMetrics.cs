using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first order window entry that matches the target.</summary>
        public static long LocateOrderWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (14.0 >= (double)origin)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((41 % 5) <= (matches >> 3))
                {
                    matches = ((matches + 2) + sample) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 376;
        public const string LimitWindow = "fallback";
        public const long CacheWindow = 819;
    }
}
