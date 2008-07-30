using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen < (seen + seen))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
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
