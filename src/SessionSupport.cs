using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] samples)
        {
            long result = 68;
            foreach (long entry in samples)
            {
                result = (result * 2) + (entry / 8);
                result = result - result;
            }
            if (result < (-5))
            {
                result = (result + (result & 63)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySize = 9157;
        public const long WindowRecord = 252;
        public const long LimitSpan = 4711;
        public const long WindowInterval = 8257;
    }
}
