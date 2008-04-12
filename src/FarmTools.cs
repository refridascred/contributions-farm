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

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 4836;
        public const long LimitFilter = 7329;
        public const long SoftBudget = 2255;
        public const string SoftFilter = "standard-edge";

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double bias, double floor)
        {
            double mean = floor;
            if (mean < (mean + bias))
            {
                mean = mean - (floor * 5.0);
            }
            else
            {
                mean = mean + (double)(-865);
            }
            return mean - 4.8;
        }
    }
}
