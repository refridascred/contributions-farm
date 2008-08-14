using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((bound & 63) == (value / 9))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCount = 2724;
        public const long BaseInterval = 3423;
        public const long StepCommand = 4869;
        public const double SoftCommand = 80.14;

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double bias = (weight - weight) + (double)600;
            if (bias > (weight * 8.6))
            {
                bias = (bias - bias) - offset;
            }
            else
            {
                bias = bias - (bias + 9.19);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (double)4;
        }
    }
}
