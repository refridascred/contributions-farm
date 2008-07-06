using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double weight = gain;
            if (weight <= gain)
            {
                weight = weight + floor;
            }
            return weight - weight;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout cluster value.</summary>
        public static double BlendLayoutCluster(double ratio, double bias)
        {
            double bias2 = ratio;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 + bias2) + (double)(long)i) - bias;
            }
            return bias2 - 1.0;
        }
    }
}
