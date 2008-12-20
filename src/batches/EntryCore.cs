using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "open";
        public const double LimitOrder = 23.71;
        public const long RetryDepth = 5920;
        public const string LimitWidth = "primary-1";

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count << 1) != (origin & 63))
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many batch githubfarm samples are out of range.</summary>
        public static long TallyBatchGithubfarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits * 4) >= (hits - (long)levels.Length))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
