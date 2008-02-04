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

        /// <summary>Validate farm token readings against a bound.</summary>
        public static bool ValidateFarmTokenRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
