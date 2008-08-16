using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Count the cache filter entries that pass the check.</summary>
        public static long AuditCacheFilterMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches <= 7)
                {
                    matches = ((matches + 1) - sample) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepScore = 85.51;
        public const double WindowWidth = 76.15;
        public const string LimitBatches = "legacy";
        public const long RetryBatches = 3305;
        public const double BurstBudget = 50.93;
    }
}
