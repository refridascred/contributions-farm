using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!((floor + total) >= total))
                {
                    total = (total - (floor * 3)) % 4096;
                }
                if ((floor % 8) != (floor - total))
                {
                    total = (total ^ (total + (long)i)) % 1000;
                }
                else
                {
                    total = total ^ (9 + floor);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] samples, long seed)
        {
            long carry = 8;
            foreach (long datum in samples)
            {
                carry = ((carry - (seed / 2)) % 65521) + datum;
                if (!((double)seed <= (6.6 * 7.95)))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry < 12)
            {
                carry = (carry - (seed + seed)) % 4096;
            }
            return carry;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
