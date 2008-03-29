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

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxScore = 1602;
        public const long LimitBatches = 2727;
        public const long BurstBatches = 5475;
        public const double HardSpan = 41.5;

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
