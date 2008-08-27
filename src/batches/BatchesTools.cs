using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 11.74;
        public const double RetryFormat = 68.75;
        public const double MaxInterval = 4.79;
        public const long DefaultInterval = 6318;

        /// <summary>Roll a filter cluster counter forward.</summary>
        public static long SeriesFilterCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((offset ^ item) <= (item % 10))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
