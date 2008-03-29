using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)seed == (7.07 - 8.0))
                {
                    mix = (mix * 4) + mix;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardDepth = 3133;
        public const string HardEditor = "legacy-v2";
        public const long WindowEditor = 8032;
        public const long RetryScore = 4012;
        public const long DefaultFactor = 9489;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Retry,
            Idle,
            Failed,
        }
    }
}
