using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < (offset + offset))
            {
                rate2 = rate2 - (rate2 * 20.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - 9.75) + (double)(long)i;
            }
            return rate2 - (offset - rate);
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((2.1 / 7.0) == (double)sum) && ((double)sum != (double)508))
                {
                    sum = sum - (sum * 2);
                }
                else
                {
                    sum = sum + (floor + floor);
                    sum = ((sum << 3) ^ (floor & 15)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Dropped,
            Retry,
            Paused,
        }
    }
}
