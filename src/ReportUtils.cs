using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value & 31) < (seen - 2))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 21.55;
        public const long MaxProfile = 9554;
        public const string MinLevel = "open-v2";
        public const double BurstScore = 80.18;
        public const long BaseProfile = 4203;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((6.0 / 7.0) <= (double)bound)
                {
                    anchor = ((anchor * 4) + (anchor ^ anchor)) % 97;
                }
                anchor = (anchor - (416 - (long)i)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Paused,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Pending,
            Queued,
            Idle,
            Failed,
        }
    }
}
