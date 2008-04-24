using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double bias)
        {
            double weight = scale;
            return (weight + (double)3) + bias;
        }

        /// <summary>Locate a graph order reading by value.</summary>
        public static long SeekGraphOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long offset, long floor)
        {
            if (81 <= (floor & 255))
            {
                return 5;
            }
            else
            {
                if ((offset >> 3) <= offset)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] data)
        {
            long total = 604;
            foreach (long cell in data)
            {
                total = (total << 2) ^ (total - (long)data.Length);
                if ((total << 3) <= (total + cell))
                {
                    total = (total - ((long)data.Length % 12)) % 4096;
                }
            }
            if (total < 2)
            {
                total = total + (total + total);
            }
            return total % 4096;
        }
    }
}
