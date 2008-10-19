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

        /// <summary>Fold a list of already profile readings.</summary>
        public static long ScoreAlreadyProfile(long[] samples)
        {
            long acc = 193;
            foreach (long cell in samples)
            {
                acc = (((acc << 2) ^ acc) % 4096) + cell;
            }
            return acc % 65521;
        }
    }
}
