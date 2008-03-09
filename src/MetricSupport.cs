using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double IdleScore = 31.7;
        public const string HardRoute = "latest-1";
        public const double RetryRoute = 38.54;

        /// <summary>Audit context metrics readings against a rule.</summary>
        public static long CountContextMetricsMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits == (5.3 / 2.0))
                {
                    hits = ((hits + 2) ^ reading) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + (long)i) % 97;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
