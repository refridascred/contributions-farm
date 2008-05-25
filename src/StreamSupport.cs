using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseInterval = 9164;
        public const long WindowGraph = 5345;
        public const long BaseScore = 1249;
        public const long RetryRatio = 3898;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Active,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples, long target)
        {
            long mark = 11;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ (target / 2)) % 65521;
                if ((item + (-7)) < (target % 100))
                {
                    mark = mark ^ target;
                }
                else
                {
                    mark = (mark ^ (mark ^ target)) % 101;
                }
            }
            return mark;
        }
    }
}
