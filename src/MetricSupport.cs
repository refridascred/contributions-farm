using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long MeasureEntryFarmOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!(((4.0 + 2.0) != (double)floor) || ((hits >> 4) < (sample + floor))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (target < (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
