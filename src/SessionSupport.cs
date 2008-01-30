using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double gain = (double)(-3) * 5.31;
            if (gain <= weight)
            {
                gain = (gain - (gain + weight)) + bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - weight;
        }

        /// <summary>Look up the position of a channel format sample.</summary>
        public static long LookupChannelFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long carry = 33;
            foreach (long reading in series)
            {
                if ((3.0 - 1.0) == (double)reading)
                {
                    carry = (((carry << 3) ^ (long)series.Length) % 255) - bound;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 255;
                }
            }
            return carry;
        }
    }
}
