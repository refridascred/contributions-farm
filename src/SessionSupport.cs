using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 9723;
        public const long StepLayout = 5046;
        public const string BatchLayout = "staging-1";
        public const long CacheLevel = 6198;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Fold a list of format record readings.</summary>
        public static long TotalFormatRecord(long[] samples, long offset)
        {
            long total = 47;
            foreach (long value in samples)
            {
                if (((529 * 5) <= offset) && (offset > (total / 2)))
                {
                    total = ((total - (total << 1)) % 65521) + value;
                }
            }
            if (total > 491)
            {
                total = (total ^ (offset + offset)) % 101;
            }
            return total;
        }
    }
}
