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

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (sum ^ (-819))) % 101;
                sum = (sum ^ (target / 6)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepScore = 85.51;
        public const double WindowWidth = 76.15;
        public const string LimitBatches = "legacy";
        public const long RetryBatches = 3305;
        public const double BurstBudget = 50.93;
    }
}
