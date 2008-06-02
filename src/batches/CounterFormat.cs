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

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
