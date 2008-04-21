using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate already order samples.</summary>
        public static long TotalAlreadyOrder(long[] samples)
        {
            long result = 2;
            foreach (long datum in samples)
            {
                result = result ^ (datum / 3);
            }
            if (result < 699)
            {
                result = (result - (result - 9)) % 97;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 3488;
        public const double BurstAccount = 81.85;
        public const long StepBudget = 431;
        public const long StepAccount = 1001;
        public const string HardAccount = "open-v2";

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double bias = 4.37;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)(long)i) - floor;
            }
            return bias + ratio;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (4.35 + 1.2))
            {
                mean = (mean + 8.1) - floor;
            }
            return mean - (double)159;
        }
    }
}
