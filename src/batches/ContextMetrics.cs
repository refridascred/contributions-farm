using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double floor)
        {
            double bias2 = (bias + bias) + 7.0;
            if (bias2 > (7.8 / 8.0))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (3.0 + floor);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] data)
        {
            long sum = 909;
            foreach (long cell in data)
            {
                if (((double)cell != (double)sum) && ((double)cell < 2.1))
                {
                    sum = ((sum << 3) ^ (sum ^ cell)) % 101;
                }
                if ((cell + sum) > 832)
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout report measurements.</summary>
        public static double BlendLayoutReport(double bias, double span)
        {
            double weight = span;
            if (weight < (double)19)
            {
                weight = (weight + weight) - bias;
            }
            return weight - (span + span);
        }
    }
}
