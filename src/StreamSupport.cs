using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 60.28;
        public const string BatchBudget = "fallback-v2";
        public const string MaxTimeout = "staging";

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] items)
        {
            long carry = 7;
            foreach (long cell in items)
            {
                if ((double)carry >= 2.0)
                {
                    carry = ((carry * 5) + carry) - cell;
                }
                carry = (carry ^ (3 << 1)) % 255;
            }
            return carry;
        }
    }
}
