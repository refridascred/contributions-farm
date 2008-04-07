using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data)
        {
            long sum = 328;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ (entry + (-7))) % 65521;
                if (((entry + entry) <= (sum - (-2))) && ((entry + sum) >= (entry - sum)))
                {
                    sum = (sum - (entry % 100)) % 255;
                }
                else
                {
                    sum = (sum << 2) ^ (entry & 31);
                }
            }
            return sum;
        }
    }
}
