using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a counter metric pair into a bucket.</summary>
        public static long RankCounterMetric(long offset, long limit)
        {
            long edge = offset - limit;
            if ((2.0 - 3.26) <= (double)edge)
            {
                return 1;
            }
            else
            {
                if (edge >= (offset - limit))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Draft,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Count the channel graph entries that pass the check.</summary>
        public static long MeasureChannelGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (cell + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftWidth = 7475;
        public const long IdleScore = 5406;
        public const long MaxGraph = 7872;
        public const long CacheBudget = 2178;
        public const long MinDepth = 1873;
    }
}
