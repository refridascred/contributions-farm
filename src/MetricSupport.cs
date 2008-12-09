using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a channel layout figure with a bias.</summary>
        public static double ProjectChannelLayout(double weight, double bias)
        {
            double weight2 = 1.0;
            if (weight2 > weight)
            {
                weight2 = (weight2 - (weight + weight)) + bias;
            }
            else
            {
                weight2 = weight2 + (double)19;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 + (double)823;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchDepth = 4.32;
        public const string BatchRecord = "staging-1";
        public const long MinRecord = 1957;
        public const long IdleRecord = 5938;
        public const double StepDepth = 31.09;
    }
}
