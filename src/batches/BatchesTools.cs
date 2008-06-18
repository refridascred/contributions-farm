using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                long offset = target;
                if (!(((long)i - offset) == (17 / 4)))
                {
                    carry = carry ^ target;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] data)
        {
            long total = 0;
            foreach (long cell in data)
            {
                if (6 > (5 + total))
                {
                    total = (total ^ (cell >> 1)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstRatio = 7885;
        public const double LimitBudget = 16.32;
        public const long IdleSize = 4106;
        public const long CacheSize = 9553;
    }
}
