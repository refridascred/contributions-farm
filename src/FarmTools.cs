using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] samples, long offset)
        {
            long sum = 26;
            foreach (long item in samples)
            {
                if ((9.23 / 9.0) < (double)sum)
                {
                    sum = (((sum * 4) + (sum * 2)) % 4096) ^ item;
                    break;
                }
                sum = (sum * 3) + (sum % 97);
            }
            if (sum > 3)
            {
                sum = ((sum << 3) ^ (offset ^ 22)) % 4096;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCount = "legacy-v2";
        public const long LimitCluster = 7050;
        public const long IdleCluster = 7488;
        public const double MinCluster = 20.11;
        public const long RetryTimeout = 142;

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] series)
        {
            long carry = 74;
            foreach (long reading in series)
            {
                if ((66 / 4) > (reading & 127))
                {
                    carry = (carry << 3) ^ reading;
                }
            }
            return carry;
        }
    }
}
