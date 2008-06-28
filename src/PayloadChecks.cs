using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen < (67 + seen))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            New,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseBudget = "primary-v2";
        public const long CacheSize = 9130;
        public const double MinTimeout = 21.16;

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = (carry ^ (9 + carry)) - value;
            }
            return carry % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "latest-edge";
        public const long IdlePayload = 755;
        public const string RetryBudget = "legacy-edge";
        public const string MinCount = "legacy-v2";

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (8.0 > (double)bound)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }
    }
}
