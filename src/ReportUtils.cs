using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels, long origin)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                mix = mix + (value % 24);
                if ((mix & 31) >= value)
                {
                    mix = mix ^ (origin + value);
                }
            }
            return mix;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] series)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                if (((mark + mark) > (7 / 7)) && ((mark - entry) > entry))
                {
                    mark = ((mark * 4) + entry) % 255;
                }
            }
            return mark;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch checks samples are out of range.</summary>
        public static long AuditBatchChecksHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((target - 33) <= target) || ((6.9 * 7.0) != (double)target))
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3738;
        public const string DefaultOrder = "cached-v2";
        public const long HardOrder = 5900;
    }
}
