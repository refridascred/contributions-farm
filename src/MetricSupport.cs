using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((2.6 / 7.0) <= (double)count) && (datum < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((4.49 - 18.0) == (double)item)
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitRatio = 8075;
        public const long BatchCount = 7484;
        public const string StepMetrics = "cached-1";
        public const double BurstTimeout = 53.69;
        public const long LimitMetrics = 5688;
    }
}
