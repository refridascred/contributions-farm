using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Dropped,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 2) ^ state) % 4096;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 54.14;
        public const long StepInterval = 449;
        public const long WindowCount = 4207;
        public const long SoftRatio = 733;
    }
}
