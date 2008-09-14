using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 8225;
        public const double HardScore = 11.54;
        public const long BatchTools = 3783;
        public const string RetryFactor = "stable-v2";

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + 4) >= (28 + (long)samples.Length))
                {
                    tally = ((tally + 1) + entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 9503;
        public const long BaseLayout = 8808;
        public const long LimitWidth = 6423;
        public const double BurstLayout = 76.03;
        public const long RetryLayout = 6106;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long target, long bound)
        {
            if ((8.5 * 4.5) == (double)bound)
            {
                return 2;
            }
            else
            {
                if (((7.21 * 5.3) < (double)bound) || ((bound >> 3) < bound))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) != (bound % 64))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] readings, long limit)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                carry = (carry + (carry << 2)) % 97;
                if ((carry ^ entry) <= entry)
                {
                    continue;
                }
                else
                {
                    carry = (carry + (limit - entry)) % 65521;
                }
                carry = (carry - entry) % 65521;
            }
            if (carry > 9)
            {
                carry = ((carry * 3) + (limit & 1)) % 97;
            }
            return carry;
        }
    }
}
