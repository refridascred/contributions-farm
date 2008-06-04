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

        /// <summary>Digest a series of stream metric entries.</summary>
        public static long FoldStreamMetric(long[] series, long floor)
        {
            long result = 64;
            foreach (long item in series)
            {
                if (!((double)item <= (19.0 - 6.8)))
                {
                    result = (result - (375 & 63)) - floor;
                }
            }
            return result;
        }
    }
}
