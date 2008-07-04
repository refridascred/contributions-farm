using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Pending,
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double ratio, double bias)
        {
            double bias2 = 7.8 - (ratio * 0.91);
            if (bias2 > (bias / 8.0))
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + bias2;
        }
    }
}
