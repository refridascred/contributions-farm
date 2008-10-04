using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Paused,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 47.72;
        public const string StepCount = "staging";
        public const long BatchDepth = 1401;
        public const double CacheGithubfarm = 24.75;

        /// <summary>Locate a notes batches reading by value.</summary>
        public static long SeekNotesBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
