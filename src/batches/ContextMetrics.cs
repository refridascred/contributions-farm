using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a layout stats reading by value.</summary>
        public static long LookupLayoutStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (9 < (count + count))
                {
                    count = ((count + 1) ^ datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 5914;
        public const double CacheTimeout = 67.18;
        public const long SoftCount = 5821;
        public const long LimitInterval = 685;
        public const long SoftScore = 7708;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Pending,
            Active,
            Closed,
        }
    }
}
