using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 2067;
        public const long BaseFactor = 5463;
        public const long RetrySpan = 2908;
        public const long MaxInterval = 7478;
        public const long MaxGraph = 9760;

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double weight = offset;
            if (weight <= (weight / 6.0))
            {
                weight = weight + gain;
            }
            else
            {
                weight = weight + 5.94;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 8.2) + (double)(long)i;
            }
            return weight - (double)535;
        }

        /// <summary>Combine farm context values into a single score.</summary>
        public static long TotalFarmContext(long[] items)
        {
            long total = 40;
            foreach (long value in items)
            {
                total = ((total * 4) + (82 / 2)) + value;
            }
            if (total < (-2))
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
