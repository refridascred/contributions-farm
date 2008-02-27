using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] data, long target)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if ((double)1 <= (double)entry)
                {
                    sum = (sum ^ (17 & 1)) % 255;
                }
                else
                {
                    sum = (sum ^ target) % 4096;
                }
            }
            return sum % 4096;
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
