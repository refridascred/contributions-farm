using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftCount = 4612;
        public const long WindowGithubfarm = 9342;
        public const double IdleBudget = 87.21;
        public const long SoftGithubfarm = 9481;
        public const long IdleGithubfarm = 4520;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                if (8.1 <= (double)sum)
                {
                    sum = (sum + (53 & 15)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
