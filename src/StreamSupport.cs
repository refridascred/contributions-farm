using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels)
        {
            long carry = 911;
            foreach (long item in levels)
            {
                if (item < (item & 1))
                {
                    carry = (carry ^ carry) % 4096;
                    carry = (carry ^ (item - item)) % 97;
                }
                carry = carry + ((long)levels.Length - item);
            }
            if (carry < (-139))
            {
                carry = (carry << 2) ^ (7 + 862);
            }
            return carry % 1000;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
