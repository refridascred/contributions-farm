using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "staging-v2";
        public const long HardInterval = 7567;
        public const string StepStats = "standard-v2";
        public const long StepRatio = 7725;

        /// <summary>Look up the position of a context graph sample.</summary>
        public static long FindContextGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
