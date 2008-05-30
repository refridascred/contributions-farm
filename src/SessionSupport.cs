using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items, long limit)
        {
            long carry = 8;
            foreach (long datum in items)
            {
                carry = (carry + (25 + limit)) % 101;
                if (datum <= (datum * 5))
                {
                    carry = (carry * 3) + (450 % 60);
                }
                else
                {
                    carry = carry - (datum + limit);
                }
            }
            return carry % 97;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double gain, double bias)
        {
            double drift = gain;
            if (drift > 5.06)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + (6.94 * 5.8);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (double)55;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
