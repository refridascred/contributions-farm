using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the order format series from a seed.</summary>
        public static long StepOrderFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = (state ^ (state * 3)) % 1000;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Paused,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 8964;
        public const long BurstQueue = 3284;
        public const long MinInterval = 1278;
        public const long SoftDepth = 2149;
    }
}
