using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 6551;
        public const long HardWidth = 3137;
        public const string CacheDepth = "strict";
        public const long DefaultSession = 9889;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 8306;
        public const long LimitTimeout = 835;
        public const string RetrySpan = "strict-v2";
        public const long WindowSize = 1384;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
