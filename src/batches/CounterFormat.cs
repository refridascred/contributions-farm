using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 326;
        public const string DefaultCluster = "staging-v2";
        public const string LimitBudget = "standard-v2";
        public const long MinCluster = 2600;

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long total = 208;
            foreach (long item in data)
            {
                total = ((total - (total >> 3)) % 1000) - item;
            }
            return total % 97;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double rate, double bias)
        {
            double gain = rate;
            if (gain < 8.0)
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (gain + bias);
        }
    }
}
