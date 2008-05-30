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

        /// <summary>Check that every githubfarm route entry stays within the limit.</summary>
        public static bool CheckGithubfarmRouteRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
