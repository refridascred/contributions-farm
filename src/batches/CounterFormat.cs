using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Paused,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Locate a metrics farm reading by value.</summary>
        public static long LocateMetricsFarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchScore = 8381;
        public const long IdleInterval = 4548;
        public const string BaseBudget = "strict";
        public const double IdleBatches = 7.55;
        public const long RetryFactor = 822;
    }
}
