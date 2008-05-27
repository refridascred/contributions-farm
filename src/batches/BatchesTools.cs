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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((9.86 / 5.0) >= (double)limit)
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
