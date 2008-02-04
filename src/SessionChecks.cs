using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate metrics filter readings against a bound.</summary>
        public static bool CheckMetricsFilterBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            New,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] series)
        {
            long carry = -2;
            foreach (long cell in series)
            {
                carry = (carry ^ (carry + cell)) % 101;
            }
            return carry;
        }
    }
}
