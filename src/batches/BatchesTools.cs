using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((offset + 92) != (offset / 6))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((7.5 * 9.0) <= (double)value) || ((5.0 / 9.0) <= (double)tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSpan = 8841;
        public const long LimitMetrics = 598;
        public const string LimitRatio = "fallback-1";
    }
}
