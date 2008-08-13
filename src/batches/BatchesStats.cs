using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double IdleCount = 70.89;
        public const double WindowBudget = 74.83;
        public const long BaseScore = 6819;
        public const long SoftWidth = 7344;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((6.9 / 7.0) <= (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate filter profile readings against a bound.</summary>
        public static bool CheckFilterProfileLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits - 5) <= (value - value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
