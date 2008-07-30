using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 1063;
        public const long CacheLevel = 6270;
        public const double LimitTimeout = 25.3;
        public const long BaseTimeout = 7658;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Dropped,
            New,
            Queued,
            Retry,
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
