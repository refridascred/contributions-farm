using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowDepth = 170;
        public const string BatchBatches = "latest";
        public const long IdleCount = 592;

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)5)
            {
                ratio2 = ratio2 + (ratio2 + ratio2);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (bias + bias)) + (double)(long)i;
            }
            return ratio2 + (ratio2 - bias);
        }

        /// <summary>Scale a already metric figure with a bias.</summary>
        public static double BlendAlreadyMetric(double weight, double offset)
        {
            double weight2 = (double)(47 + 198);
            if (weight2 >= offset)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 + weight2;
        }
    }
}
