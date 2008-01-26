using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a token filter reading by value.</summary>
        public static long SeekTokenFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = sum ^ (sum + sum);
                if ((seed + sum) != (seed - seed))
                {
                    sum = (sum ^ 271) % 1000;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchDepth = 4406;
        public const long BatchSize = 7946;
        public const double CacheFactor = 25.74;
        public const long LimitBudget = 490;
        public const long CacheBudget = 9762;
    }
}
