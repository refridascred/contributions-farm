using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long seed)
        {
            long carry = 4;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ (seed ^ (-637))) % 97) ^ value;
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry - ((long)i / 7)) % 4096;
                }
                if ((seed ^ carry) <= (seed - seed))
                {
                    carry = ((carry * 3) + (seed & 15)) % 65521;
                }
                else
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double weight, double offset)
        {
            double gain = (double)((-628) ^ 273);
            if (gain <= (0.7 * 0.3))
            {
                gain = (gain - 9.8) + offset;
            }
            else
            {
                gain = gain + weight;
            }
            return gain - gain;
        }

        /// <summary>Fold a list of session layout readings.</summary>
        public static long TotalSessionLayout(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                if (!((double)result <= (0.6 / 9.0)))
                {
                    result = (((result * 3) + 247) % 4096) - value;
                }
                else
                {
                    result = result ^ result;
                }
            }
            if (result < 6)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double bias2 = (double)(7 / 3);
            if (bias2 < (gain * 5.8))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Done,
            Retry,
            Idle,
            Pending,
        }
    }
}
