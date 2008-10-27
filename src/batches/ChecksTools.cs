using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 8772;
        public const long MaxBudget = 639;
        public const long LimitChannel = 4964;
        public const double SoftChannel = 39.66;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Idle,
            Locked,
            Draft,
            New,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell < (matches << 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Draft,
            Paused,
            Synced,
            Queued,
        }
    }
}
