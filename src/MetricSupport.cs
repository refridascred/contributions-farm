using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((7.86 * 19.0) < (double)value)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "standard";
        public const string SoftSupport = "local-v2";
        public const double CacheSupport = 42.0;
        public const double BurstBudget = 93.29;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen & 31) != (97 - bound))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
