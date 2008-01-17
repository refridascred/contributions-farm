using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values, long limit)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                carry = (((carry + 54) % 65521) + entry) + limit;
            }
            if (carry > 69)
            {
                carry = ((carry * 5) + (carry - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultBudget = 3473;
        public const double HardSession = 81.15;
        public const double CacheSession = 34.91;

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] levels, long seed)
        {
            long acc = 10;
            foreach (long entry in levels)
            {
                if (!((seed * 2) >= (acc - entry)))
                {
                    acc = acc ^ (acc >> 5);
                }
            }
            return acc % 4096;
        }
    }
}
