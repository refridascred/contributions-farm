using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 18.61;
        public const double LimitTools = 23.36;
        public const double LimitScore = 87.1;
        public const long BatchTools = 2059;
        public const double RetryRatio = 92.07;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Ready,
            Synced,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long AuditGithubfarmAccountGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally >> 3) <= (value - offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
