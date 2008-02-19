using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheFactor = 2678;
        public const long MinLevel = 8711;
        public const string MaxSpan = "staging-v2";
        public const long MaxBudget = 3695;
        public const string MinRecord = "cached-v2";

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
