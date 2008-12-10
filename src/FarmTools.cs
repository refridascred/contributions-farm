using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next editor stream value from a seed.</summary>
        public static long StepEditorStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Active,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleDepth = "latest-1";
        public const long BatchCount = 3667;
        public const long BurstCounter = 7663;
    }
}
