using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up layout cache samples.</summary>
        public static long MatchLayoutCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double load = bias;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - 3.6) - (double)(long)i) + bias2;
            }
            return load - (double)889;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepSpan = 7467;
        public const long BurstWidth = 5604;
        public const long MaxOrder = 2472;
        public const string DefaultFactor = "open-edge";
    }
}
