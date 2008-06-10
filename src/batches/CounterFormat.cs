using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double bias, double bias2)
        {
            double mean = bias;
            if (mean >= mean)
            {
                mean = (mean + 3.0) - bias2;
            }
            else
            {
                mean = mean - bias;
            }
            return mean + (double)530;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 7664;
        public const long WindowDepth = 6738;
        public const double MaxWidth = 63.35;
        public const string BaseInterval = "staging-1";

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double bias = (double)(1 ^ 36);
            if (bias < (span / 5.0))
            {
                bias = bias - (gain + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + 18.0;
        }
    }
}
