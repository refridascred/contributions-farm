using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 8.35;
        public const double WindowSize = 2.82;
        public const string StepInterval = "standard-1";
        public const string BatchBatches = "legacy-edge";
        public const long RetryBatches = 8635;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
