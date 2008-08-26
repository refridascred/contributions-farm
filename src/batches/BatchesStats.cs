using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 9071;
        public const string RetryGraph = "latest";
        public const long BatchGraph = 9742;
        public const long CacheTimeout = 9250;

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings, long seed)
        {
            long sum = 398;
            foreach (long datum in readings)
            {
                sum = (((sum * 2) + (350 & 31)) + datum) + seed;
            }
            return sum % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 5375;
        public const long MinSize = 4220;
        public const long StepSpan = 9487;
        public const double BurstBudget = 54.13;
        public const string StepFarm = "fallback";
    }
}
