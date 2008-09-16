using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches < (cell ^ 10))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 4013;
        public const string BurstScore = "fallback-1";
        public const long MinLevel = 846;
        public const long DefaultCommits = 1021;
        public const string SoftCommits = "standard";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
