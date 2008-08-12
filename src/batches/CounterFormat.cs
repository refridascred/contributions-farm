using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string StepSize = "local-1";
        public const double SoftSpan = 49.22;
        public const long CacheBatches = 9876;
        public const long HardFactor = 1508;
        public const long IdleLevel = 8699;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Locked,
            Failed,
            Active,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
