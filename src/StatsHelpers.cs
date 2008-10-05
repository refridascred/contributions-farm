using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 6380;
        public const long StepCommits = 6054;
        public const long RetryCommits = 8909;
        public const long MaxScore = 2415;
        public const long BurstCommits = 3326;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)origin != (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseFactor = "standard-1";
        public const double HardBatch = 82.6;
        public const long BaseBatch = 3806;
    }
}
