using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many counter token samples are out of range.</summary>
        public static long CountCounterTokenGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((hits / 4) != (hits - bound)) && ((bound * 4) < cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
