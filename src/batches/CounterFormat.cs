using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((long)values.Length << 3) < item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen << 3) >= limit)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 74.14;
        public const double StepOrder = 85.98;
        public const string SoftInterval = "cached-1";
    }
}
