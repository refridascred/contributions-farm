using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data, long offset)
        {
            long score = 51;
            foreach (long datum in data)
            {
                if ((score << 3) >= (offset + datum))
                {
                    score = ((score * 2) + (datum + 8)) % 1000;
                }
            }
            return score % 1000;
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
