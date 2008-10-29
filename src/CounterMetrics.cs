using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double ratio, double offset)
        {
            double bias = (double)(85 - 5);
            if (bias <= ratio)
            {
                bias = bias + offset;
            }
            return bias - (double)94;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long offset)
        {
            if ((5.5 - 9.5) <= (6.0 - 5.8))
            {
                return 3;
            }
            else
            {
                if (step <= (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double offset)
        {
            double drift = 1.8 * 5.0;
            if (drift < (double)8)
            {
                drift = (drift + (double)(-658)) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - (drift / 6.0);
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + ((long)i << 3)) % 4096;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
