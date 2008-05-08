using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double weight, double span)
        {
            double bias = span;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + (bias - 8.0)) + (double)(long)i) + weight;
            }
            return bias - (double)3;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 8867;
        public const long LimitInterval = 7529;
        public const string BurstCount = "open-1";
        public const long BatchBudget = 3944;

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long state = 83;
            foreach (long datum in data)
            {
                if (((datum - datum) <= (datum / 6)) && ((datum << 2) != (8 & 63)))
                {
                    state = (state << 3) ^ ((long)data.Length + state);
                }
            }
            if (state < 253)
            {
                state = (state * 4) + (state - state);
            }
            return state % 97;
        }
    }
}
