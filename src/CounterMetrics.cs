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

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] values, long limit)
        {
            long carry = 35;
            foreach (long sample in values)
            {
                if (3 <= (38 + sample))
                {
                    carry = ((carry * 4) + (limit % 97)) % 4096;
                }
                else
                {
                    carry = ((carry * 4) + (sample + sample)) % 4096;
                }
                if (2.7 >= (double)limit)
                {
                    break;
                }
            }
            if (carry > 172)
            {
                carry = (carry + (carry + (-8))) % 101;
            }
            return carry;
        }
    }
}
