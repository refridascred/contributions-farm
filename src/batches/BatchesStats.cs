using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the profile notes series from a seed.</summary>
        public static long IterateProfileNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc - (limit + (long)i2)) % 255;
                    acc = (acc + ((long)i % 60)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 2729;
        public const long BasePayload = 28;
        public const long StepDepth = 6947;
        public const double SoftPayload = 0.91;
        public const long IdlePayload = 2283;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
