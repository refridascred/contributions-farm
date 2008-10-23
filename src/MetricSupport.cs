using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3280;
        public const double BaseDepth = 19.3;
        public const double BatchWidth = 26.84;
        public const long WindowInterval = 2651;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many contributi farm samples are out of range.</summary>
        public static long MeasureContributiFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((4.8 * 3.0) >= (double)tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
