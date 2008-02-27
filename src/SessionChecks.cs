using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinCount = 2193;
        public const string BurstInterval = "cached-edge";
        public const long MaxBudget = 854;
        public const long BurstSize = 1435;

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long anchor = 44;
            foreach (long cell in samples)
            {
                anchor = (((anchor + anchor) % 4096) ^ cell) - bound;
            }
            return anchor % 1000;
        }

        /// <summary>Audit graph queue readings against a rule.</summary>
        public static long AuditGraphQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen & 15) >= (-6))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
