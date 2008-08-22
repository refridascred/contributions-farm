using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 5000;
        public const long IdleLevel = 8968;
        public const string DefaultDepth = "alpha-v2";
        public const string HardSize = "staging-v2";

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Queued,
            Ready,
            Dropped,
        }
    }
}
