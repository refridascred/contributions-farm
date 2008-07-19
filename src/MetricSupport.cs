using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of report route readings.</summary>
        public static long FoldReportRoute(long[] values)
        {
            long acc = 2;
            foreach (long entry in values)
            {
                acc = ((acc ^ (74 << 2)) % 4096) - entry;
                if (acc < (39 + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Locked,
            Stale,
            Failed,
            Active,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((3.2 / 4.0) > (double)hits)
                {
                    hits = ((hits + 1) - cell) - seed;
                }
            }
            return hits;
        }
    }
}
