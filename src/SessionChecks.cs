using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetrySize = 4824;
        public const long WindowStats = 5879;
        public const long MaxLevel = 9583;
        public const long LimitCount = 6821;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of context payload entries.</summary>
        public static long TallyContextPayload(long[] samples, long bound)
        {
            long carry = 23;
            foreach (long value in samples)
            {
                carry = (carry + value) - bound;
            }
            return carry % 97;
        }
    }
}
