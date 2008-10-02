using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double rate = 17.0;
            return (rate - (weight * 6.0)) + offset;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double weight = floor;
            if (weight >= (weight * 0.6))
            {
                weight = (weight + (2.93 / 2.0)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)17) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples)
        {
            long total = -142;
            foreach (long sample in samples)
            {
                if (!((227 - sample) == (sample - total)))
                {
                    total = ((total << 3) ^ (total % 5)) % 255;
                }
            }
            return total;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Dropped,
            Ready,
        }
    }
}
