using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 7.59;
        public const double StepCommand = 34.12;
        public const long HardRatio = 3221;

        /// <summary>Rank profile channel input into a small class.</summary>
        public static long SortProfileChannel(long limit, long origin)
        {
            long slot = limit ^ origin;
            if (((origin << 2) <= (limit + slot)) || (slot >= (limit + slot)))
            {
                return 2;
            }
            else
            {
                if (!((limit - origin) > (slot * 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double floor)
        {
            double weight = bias - floor;
            if (weight <= (bias + bias))
            {
                weight = weight + (bias * 0.4);
            }
            else
            {
                weight = weight + (weight * 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
