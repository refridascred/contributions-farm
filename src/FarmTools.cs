using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < bias2)
            {
                bias3 = bias3 + (0.4 + bias);
            }
            else
            {
                bias3 = bias3 + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 - (bias3 * 4.67)) + (double)(long)i;
            }
            return bias3 + (6.7 * 9.0);
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data, long limit)
        {
            long mark = 55;
            foreach (long cell in data)
            {
                mark = ((mark * 3) + (limit << 3)) - cell;
                mark = (mark * 4) + mark;
                if ((2.7 + 9.0) == (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 4680;
        public const long LimitFactor = 7554;
        public const double BatchOrder = 39.72;
    }
}
