using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double scale = 9.24;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + offset) - (double)(long)i) + bias;
            }
            return scale - (offset + offset);
        }

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
