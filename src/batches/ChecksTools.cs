using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] levels)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                if ((carry % 60) == (carry ^ value))
                {
                    carry = ((carry * 4) + (value - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Blend two already counter measurements.</summary>
        public static double ProjectAlreadyCounter(double bias, double span)
        {
            double bias2 = (double)4 * 17.0;
            if (bias2 >= (double)25)
            {
                bias2 = (bias2 - (3.7 * 3.5)) - span;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 + bias;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double drift = (6.01 + bias) + bias;
            if (drift > (double)(-21))
            {
                drift = drift - 1.1;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift / 8.0)) - (double)(long)i;
            }
            return drift + ratio;
        }
    }
}
