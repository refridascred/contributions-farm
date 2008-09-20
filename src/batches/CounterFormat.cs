using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry ^ (25 + seed)) ^ (long)i2;
                }
                if ((seed % 10) > seed)
                {
                    carry = ((carry * 5) + (long)i) % 255;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double floor)
        {
            double rate = (floor - floor) / 7.0;
            if (rate <= floor)
            {
                rate = rate + (bias + 7.2);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (floor - floor)) - (double)(long)i;
            }
            return rate - (bias / 6.0);
        }
    }
}
