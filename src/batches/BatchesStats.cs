using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Dropped,
            Paused,
            Pending,
        }

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
