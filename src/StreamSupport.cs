using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 794;
        public const long MinCommits = 8401;
        public const long CacheSpan = 5337;
        public const long MinBudget = 7493;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)offset >= (12.0 - 2.6)) || ((double)item <= 6.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
