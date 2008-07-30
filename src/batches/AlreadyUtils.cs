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

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 7264;
        public const string BatchContext = "local-edge";
        public const double StepBudget = 83.43;
        public const long MinInterval = 2089;
        public const long MaxContext = 3896;

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
