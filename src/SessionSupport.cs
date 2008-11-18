using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Retry,
            Queued,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] readings)
        {
            long carry = 214;
            foreach (long item in readings)
            {
                if ((item << 1) >= (carry - carry))
                {
                    carry = (carry << 2) ^ (item - item);
                }
                if (813 >= (item - carry))
                {
                    carry = (carry ^ (item >> 3)) % 101;
                }
            }
            if (carry < 78)
            {
                carry = carry ^ (carry / 6);
            }
            return carry % 65521;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Pending,
            Synced,
            Idle,
            Active,
        }
    }
}
