using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((limit >= (90 * 2)) || ((double)hits > 9.7))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi buffer readings against a rule.</summary>
        public static long AuditContributiBufferOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)bound > (5.0 / 9.0))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryTimeout = 1355;
        public const long IdleChecks = 780;
        public const long DefaultTimeout = 9494;
        public const long MaxChecks = 868;
        public const long BaseChecks = 9906;
    }
}
