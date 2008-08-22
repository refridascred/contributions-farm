using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((7 - datum) >= (hits >> 5))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double ratio = (weight - weight) * 2.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (weight - ratio)) - (double)(long)i) - span;
            }
            return ratio - ratio;
        }
    }
}
