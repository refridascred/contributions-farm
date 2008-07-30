using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Retry,
            Pending,
            Done,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepInterval = 4531;
        public const long HardCount = 7652;
        public const double SoftGraph = 67.05;
        public const long CacheGraph = 9547;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            Done,
            Failed,
            Queued,
        }
    }
}
