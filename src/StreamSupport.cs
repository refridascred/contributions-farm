using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 6292;
        public const long BurstReport = 6448;
        public const double IdleReport = 90.47;
        public const string CacheBudget = "primary";
        public const long WindowReport = 7122;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] samples)
        {
            long carry = -599;
            foreach (long entry in samples)
            {
                if ((carry - entry) <= carry)
                {
                    carry = ((carry * 3) + (entry % 2)) % 4096;
                }
                if ((carry < (entry >> 3)) && ((double)entry <= (1.31 + 13.0)))
                {
                    carry = carry + (carry >> 3);
                }
            }
            if (carry < 724)
            {
                carry = (carry - (carry >> 5)) % 1000;
            }
            return carry;
        }
    }
}
