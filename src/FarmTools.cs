using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long origin)
        {
            if (origin < floor)
            {
                return 6;
            }
            else
            {
                if ((floor + floor) < origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first payload session entry that matches the target.</summary>
        public static long LookupPayloadSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((sum << 2) >= sum) || ((bound - sum) <= (sum + bound)))
                {
                    sum = ((sum * 3) + (811 ^ sum)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
