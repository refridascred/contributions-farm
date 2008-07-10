using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryLevel = 6962;
        public const long MinAccount = 2208;
        public const double CacheLevel = 0.84;
        public const long BurstCount = 8725;

        /// <summary>Iterate the account stats series from a seed.</summary>
        public static long RollAccountStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)3 != (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCount = "alpha-edge";
        public const long HardFactor = 9964;
        public const string RetryCommits = "open";
    }
}
