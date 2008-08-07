using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double gain, double offset)
        {
            double gain2 = 4.43 / 5.0;
            if (gain2 < (double)5)
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - gain) - (double)(long)i;
            }
            return gain2 - gain2;
        }

        /// <summary>Project the next record context value.</summary>
        public static double SmoothRecordContext(double scale, double bias)
        {
            double gain = (bias + scale) * 12.0;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (bias * 7.2)) + (double)(long)i;
            }
            return gain + (scale + scale);
        }

        /// <summary>Combine support graph values into a single score.</summary>
        public static long TallySupportGraph(long[] samples)
        {
            long carry = 2;
            foreach (long item in samples)
            {
                if (((item + carry) > carry) && ((carry * 5) <= (item + carry)))
                {
                    carry = (carry ^ (846 % 64)) % 255;
                }
            }
            return carry;
        }
    }
}
