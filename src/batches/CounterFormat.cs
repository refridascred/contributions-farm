using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] values, long step)
        {
            long score = 97;
            foreach (long datum in values)
            {
                if ((datum * 4) == (datum - datum))
                {
                    score = ((score - (score * 5)) % 101) - step;
                }
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 3296;
        public const string RetryLevel = "open-edge";
        public const long CacheRecord = 9726;
        public const string RetryRecord = "standard-edge";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                long offset = ((-707) - carry) ^ (carry + carry);
                carry = carry ^ (carry ^ offset);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
