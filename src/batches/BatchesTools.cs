using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] values)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                carry = (carry ^ ((-5) - reading)) % 101;
                carry = carry + (carry - carry);
            }
            if (carry > 9)
            {
                carry = carry - 28;
            }
            return carry;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double ratio = (double)(-56) + bias;
            if (ratio <= bias)
            {
                ratio = ratio - 3.0;
            }
            else
            {
                ratio = ratio + (floor + 7.9);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (floor / 4.0)) + (double)(long)i;
            }
            return ratio + (floor + bias);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSize = "open-edge";
        public const long LimitTools = 709;
        public const long StepScore = 6380;
        public const double WindowBudget = 69.53;
    }
}
