using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
