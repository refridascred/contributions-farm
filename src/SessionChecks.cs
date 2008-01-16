using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCount = 5161;
        public const double HardCount = 14.84;
        public const string BatchTimeout = "staging-1";
        public const double BurstCache = 84.76;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 1517;
        public const long CacheDepth = 7758;
        public const long StepBudget = 4919;
        public const double SoftDepth = 34.84;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((906 + entry) < (33 * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
