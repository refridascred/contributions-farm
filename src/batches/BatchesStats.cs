using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long sum = 550;
            foreach (long reading in values)
            {
                sum = sum ^ (sum - reading);
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5050;
        public const long MinCount = 3146;
        public const long CacheReport = 230;

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry << 2) ^ seed;
                if ((0.4 / 6.0) == (double)carry)
                {
                    carry = carry + (long)i;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "standard-v2";
        public const double CacheMetrics = 69.3;
        public const double MinRatio = 59.86;
        public const long DefaultDepth = 3113;
        public const string RetryMetrics = "legacy-1";
    }
}
