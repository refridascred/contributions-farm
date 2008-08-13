using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit token batch readings against a rule.</summary>
        public static long AuditTokenBatchOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading >> 5) < floor)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (15.0 < (double)floor)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftInterval = 9102;
        public const string DefaultBudget = "latest-1";
        public const long BaseSpan = 9605;
        public const long DefaultRatio = 1883;
    }
}
