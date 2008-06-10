using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count queue token pairs that satisfy a relation.</summary>
        public static long OverlapQueueTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
