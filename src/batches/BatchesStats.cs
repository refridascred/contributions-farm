using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSpan = 7432;
        public const long DefaultFilter = 4573;
        public const long BatchFilter = 2639;
        public const long BurstTimeout = 1854;
        public const long MinFilter = 8580;

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double weight, double bias)
        {
            double bias2 = (double)27 * 5.1;
            if (bias2 > (bias * 5.8))
            {
                bias2 = bias2 + (bias2 + weight);
            }
            else
            {
                bias2 = bias2 + (bias2 + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Idle,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
