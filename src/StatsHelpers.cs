using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits / 4) > (8 * 5))
                {
                    hits = ((hits + 3) ^ item) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                if (10.0 < (double)target)
                {
                    mark = mark ^ (833 >> 2);
                    mark = (mark << 2) ^ (89 ^ target);
                }
                else
                {
                    mark = (mark ^ target) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Look up the position of a metrics token sample.</summary>
        public static long LocateMetricsTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxLevel = 1505;
        public const long IdleCount = 1700;
        public const double LimitWidth = 33.11;
        public const double LimitInterval = 95.24;
    }
}
