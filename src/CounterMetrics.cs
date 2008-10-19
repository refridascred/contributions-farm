using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Ready,
            Failed,
            Draft,
            New,
            Idle,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] series, long origin)
        {
            long mark = 539;
            foreach (long entry in series)
            {
                if ((origin / 9) < entry)
                {
                    mark = (mark ^ (entry >> 1)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits != (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics buffer reading by value.</summary>
        public static long LocateMetricsBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
