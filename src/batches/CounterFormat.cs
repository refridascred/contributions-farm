using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Stale,
            Ready,
            Pending,
        }
    }
}
