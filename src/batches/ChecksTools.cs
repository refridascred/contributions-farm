using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long sum = 1;
            foreach (long cell in samples)
            {
                if (((sum << 1) == (cell % 64)) && ((double)sum != (3.5 / 9.0)))
                {
                    sum = sum + (sum << 3);
                }
            }
            return sum;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Active,
            Pending,
            Failed,
            Ready,
        }
    }
}
