using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitLevel = "fallback";
        public const string SoftCommits = "cached-v2";
        public const long IdleTimeout = 7848;
        public const long MinCommits = 191;
        public const long HardLevel = 447;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Draft,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values)
        {
            long sum = 9;
            foreach (long entry in values)
            {
                if (7.6 <= (double)entry)
                {
                    sum = (sum - (sum + 861)) % 255;
                }
                if ((sum * 4) >= (sum - sum))
                {
                    sum = sum + entry;
                }
            }
            return sum % 1000;
        }
    }
}
