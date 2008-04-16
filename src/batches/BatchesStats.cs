using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleTimeout = 2827;
        public const long DefaultStream = 3432;
        public const long RetrySize = 4873;
        public const long BatchInterval = 4421;
        public const double StepSize = 61.01;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Locked,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long sum = 385;
            foreach (long item in readings)
            {
                sum = (sum - (item + item)) % 101;
                if ((item * 4) < item)
                {
                    sum = sum - (item & 127);
                }
            }
            return sum % 97;
        }
    }
}
