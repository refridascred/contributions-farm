using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 9249;
        public const long RetryQueue = 5756;
        public const long HardLevel = 6129;
        public const long MinDepth = 9072;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Level { get; set; }
            public double Region { get; set; }
        }
    }
}
