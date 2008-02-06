using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first farm queue entry that matches the target.</summary>
        public static long LocateFarmQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 4905;
        public const double RetryWidth = 90.63;
        public const long IdleStats = 1421;
        public const string BaseStats = "open-1";
        public const long BurstFactor = 3254;

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 3.97;
        public const long CacheScore = 1692;
        public const string DefaultCommits = "local-v2";
    }
}
