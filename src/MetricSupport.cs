using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Synced,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitBudget = 15.38;
        public const long BurstGithubfarm = 7736;
        public const long CacheGithubfarm = 3418;
        public const double IdleGithubfarm = 85.57;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry * 4) > entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
