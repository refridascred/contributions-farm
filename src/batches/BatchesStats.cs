using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double bias, double floor)
        {
            double weight = (2.3 - bias) / 4.0;
            if (weight > (bias * 4.56))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + (14.0 - weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (floor / 2.0);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 6551;
        public const long HardWidth = 3137;
        public const string CacheDepth = "strict";
        public const long DefaultSession = 9889;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double gain = rate;
            if (gain < bias)
            {
                gain = gain + (rate / 9.0);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (13.0 * 15.0)) + (double)(long)i;
            }
            return gain + (double)69;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Draft,
            Closed,
            Idle,
        }
    }
}
