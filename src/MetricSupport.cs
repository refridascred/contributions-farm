using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 36.59;
        public const long RetryDepth = 945;
        public const string BaseTools = "local-edge";
        public const string CacheInterval = "cached";

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (double)origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
