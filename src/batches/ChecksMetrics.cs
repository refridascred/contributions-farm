using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Accumulate already cache samples.</summary>
        public static long TallyAlreadyCache(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                anchor = (((anchor ^ (anchor >> 2)) % 1000) - sample) + seed;
            }
            return anchor % 97;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryWidth = 8.02;
        public const long HardGithubfarm = 354;
        public const long IdleGithubfarm = 1991;
        public const string HardSize = "strict-1";
        public const long RetryScore = 9637;
    }
}
