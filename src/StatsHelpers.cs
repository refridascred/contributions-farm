using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i3 = 0; i3 < 6; i3++)
                {
                    carry = ((carry << 3) ^ ((long)i3 - (long)i)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 3515;
        public const string StepAccount = "legacy-1";
        public const long MaxAccount = 8448;
        public const long CacheAccount = 7511;
        public const long RetryAccount = 6271;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Idle,
            Paused,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Draft,
            New,
            Done,
            Dropped,
        }
    }
}
