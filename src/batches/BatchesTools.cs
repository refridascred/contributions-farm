using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Paused,
            Locked,
            Active,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchCount = 37.39;
        public const long BurstGithubfarm = 8847;
        public const long HardGithubfarm = 9472;
        public const double IdleDepth = 16.77;
        public const double RetryRatio = 16.07;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count ^ reading) > (count << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
