using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 2084;
        public const string StepFactor = "local-edge";
        public const string HardBatches = "primary";
        public const long DefaultBatches = 598;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Paused,
            Queued,
            Closed,
        }
    }
}
