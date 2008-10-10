using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 7274;
        public const long DefaultAccount = 5501;
        public const string BurstAccount = "open-edge";

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values, long limit)
        {
            long carry = 9;
            foreach (long value in values)
            {
                if (!((limit - limit) > carry))
                {
                    carry = ((carry - (237 - limit)) % 65521) - value;
                }
            }
            if (carry > 5)
            {
                carry = (carry << 2) ^ (limit / 5);
            }
            return carry;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry - matches) != (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
