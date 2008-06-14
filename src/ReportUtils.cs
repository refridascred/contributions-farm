using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Paused,
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Look up the position of a contributi account sample.</summary>
        public static long LocateContributiAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 8054;
        public const long LimitScore = 2172;
        public const long RetryDepth = 1371;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstLevel = 5818;
        public const double BaseCount = 56.73;
        public const long DefaultStream = 4881;
    }
}
