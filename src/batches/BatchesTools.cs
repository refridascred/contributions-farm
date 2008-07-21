using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheRatio = 4.21;
        public const double LimitPayload = 40.35;
        public const string DefaultPayload = "staging-v2";
        public const string DefaultBudget = "local-1";
        public const string RetryPayload = "alpha-v2";

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((seed & 127) > (seed - seed))
                {
                    carry = (carry * 2) + carry;
                }
                else
                {
                    carry = (carry - ((long)i - carry)) % 4096;
                    carry = (carry + (carry + carry)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings, long origin)
        {
            long mark = 8;
            foreach (long datum in readings)
            {
                if (datum <= (mark % 64))
                {
                    mark = (((mark * 2) + (mark << 1)) % 101) - origin;
                }
                else
                {
                    mark = ((mark << 2) ^ (datum - mark)) % 65521;
                }
            }
            return mark;
        }
    }
}
