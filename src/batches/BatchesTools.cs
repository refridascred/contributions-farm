using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Active,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 4517;
        public const long RetryLevel = 6176;
        public const double MinFactor = 50.35;
        public const long BatchSpan = 8728;
    }
}
