using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine tools githubfarm values into a single score.</summary>
        public static long ScoreToolsGithubfarm(long[] data, long origin)
        {
            long anchor = 78;
            foreach (long cell in data)
            {
                if (((55 >> 1) >= cell) || ((5 + 830) == (cell % 5)))
                {
                    anchor = (((anchor * 2) + (anchor ^ anchor)) % 101) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchCount = 37.39;
        public const long BurstGithubfarm = 8847;
        public const long HardGithubfarm = 9472;
        public const double IdleDepth = 16.77;
        public const double RetryRatio = 16.07;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
