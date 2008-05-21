using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] readings)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                sum = sum ^ entry;
                if ((entry + entry) != (entry + sum))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = sum ^ (65 / 8);
            }
            return sum % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseBudget = 93.79;
        public const long StepFactor = 2924;
        public const long SoftSpan = 6112;

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double gain, double span)
        {
            double weight = gain;
            if (weight >= (double)827)
            {
                weight = (weight + (double)108) - span;
            }
            else
            {
                weight = weight - (double)(-123);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (8.5 / 9.0)) - (double)(long)i;
            }
            return weight - gain;
        }
    }
}
