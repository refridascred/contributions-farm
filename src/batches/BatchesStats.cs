using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long seed, long seed2)
        {
            if ((-37) >= seed2)
            {
                return 4;
            }
            else
            {
                if ((seed2 + seed) >= seed2)
                {
                    return 2;
                }
                else
                {
                    if (!((seed + seed) < (81 >> 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((0.75 / 6.0) == (double)seed) || ((seed2 % 7) >= (seed - seed2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
