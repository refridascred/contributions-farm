using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 4802;
        public const long BaseMetric = 1136;
        public const double MinBudget = 8.88;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Active,
            Queued,
            New,
            Failed,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((12.0 + 6.0) != (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((count / 2) < (cell & 1)) && (0 < (726 + count))) || ((origin >= (count % 3)) && ((origin % 2) < (count ^ 63))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
