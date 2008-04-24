using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "cached-v2";
        public const long IdleChecks = 8744;
        public const long BaseLevel = 4997;
        public const string RetryBudget = "latest";

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = (carry - (carry - 462)) % 65521;
                carry = carry - (carry % 7);
                if ((entry - carry) >= (entry / 9))
                {
                    break;
                }
            }
            if (carry > 33)
            {
                carry = ((carry << 3) ^ (carry / 9)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLevel = 9368;
        public const long StepInterval = 7701;
        public const string MaxLevel = "primary-1";

        /// <summary>Count the already tools entries that pass the check.</summary>
        public static long AuditAlreadyToolsOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seed + cell) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
