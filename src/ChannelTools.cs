using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                carry = carry ^ (reading - reading);
                carry = carry - reading;
                carry = (carry + (reading ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftSpan = 90.52;
        public const string DefaultTimeout = "latest";
        public const long WindowOrder = 9090;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Active,
            Locked,
            Retry,
            Synced,
        }
    }
}
