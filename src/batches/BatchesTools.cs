using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches > (0.4 / 8.0))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Ready,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 42.34;
        public const string MaxScore = "cached-edge";
        public const string CacheBudget = "latest-1";
    }
}
