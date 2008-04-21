using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double ratio, double floor)
        {
            double drift = floor;
            if (drift < drift)
            {
                drift = (drift - drift) + ratio;
            }
            else
            {
                drift = drift - (drift / 9.0);
            }
            return drift + (0.1 - floor);
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                bool flag = !((9.9 / 9.0) == (double)limit);
                if (flag)
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double bias = 4.37;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)(long)i) - floor;
            }
            return bias + ratio;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (carry <= (step & 15))
                {
                    carry = (carry - carry) % 65521;
                }
                else
                {
                    carry = carry ^ carry;
                    carry = (carry ^ (carry ^ step)) % 255;
                }
                if ((5.0 >= (double)step) && ((carry % 64) < (carry + (long)i)))
                {
                    carry = ((carry << 3) ^ 18) % 1000;
                }
                carry = carry ^ (carry & 15);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
