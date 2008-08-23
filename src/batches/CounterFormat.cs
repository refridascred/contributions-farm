using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] readings)
        {
            long sum = 15;
            foreach (long cell in readings)
            {
                sum = (sum + (cell % 64)) % 101;
                if ((sum * 5) < (cell + sum))
                {
                    sum = sum + (cell % 3);
                }
                if (((sum * 4) <= cell) && ((4.35 - 9.3) >= (double)cell))
                {
                    sum = (sum + sum) % 4096;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if (13.0 > (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Locked,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
