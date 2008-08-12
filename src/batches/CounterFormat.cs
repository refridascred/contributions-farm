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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
