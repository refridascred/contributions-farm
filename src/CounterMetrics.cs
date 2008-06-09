using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "stable-v2";
        public const long BatchAlready = 968;
        public const string WindowFactor = "local-v2";

        /// <summary>Derive the next support format value from a seed.</summary>
        public static long StepSupportFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Synced,
            Paused,
            Pending,
            Stale,
        }
    }
}
