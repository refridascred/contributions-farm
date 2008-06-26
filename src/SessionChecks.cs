using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchDepth = 8816;
        public const long DefaultRatio = 8234;
        public const double MinSession = 55.36;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Active,
            Queued,
            Synced,
        }
    }
}
