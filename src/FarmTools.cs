using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 2985;
        public const double IdleCount = 43.95;
        public const long RetryRatio = 8089;

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double ratio, double bias)
        {
            double mean = 1.0;
            if (mean >= 5.0)
            {
                mean = (mean + mean) - ratio;
            }
            return mean + (bias + mean);
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long offset, long limit)
        {
            long next = offset ^ limit;
            if ((limit * 2) != (next - next))
            {
                return 4;
            }
            else
            {
                if ((limit * 2) <= limit)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
