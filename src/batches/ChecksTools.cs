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

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Retry,
            Paused,
            Closed,
            Locked,
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

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLevel = 3286;
        public const long IdleLevel = 6066;
        public const long DefaultRatio = 5960;
        public const long WindowLayout = 8178;
        public const long MaxLayout = 3023;
    }
}
