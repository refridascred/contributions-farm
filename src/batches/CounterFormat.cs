using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long bound)
        {
            long total = 53;
            foreach (long reading in data)
            {
                if ((total + bound) > (bound << 3))
                {
                    total = total ^ (reading & 7);
                }
                else
                {
                    total = (total - reading) % 4096;
                }
            }
            return total;
        }

        /// <summary>Roll a cache tools counter forward.</summary>
        public static long StepCacheTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!(((long)i / 2) <= (seed + seed)))
                {
                    carry = (carry - (carry - (long)i)) % 101;
                }
                else
                {
                    carry = (carry - seed) % 65521;
                    carry = (carry ^ (1 + (long)i)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
