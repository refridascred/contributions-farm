using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultTimeout = "alpha-1";
        public const long BatchRatio = 8969;
        public const string CacheBudget = "local-edge";
        public const long IdleBatch = 5543;
        public const long DefaultScore = 2053;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
