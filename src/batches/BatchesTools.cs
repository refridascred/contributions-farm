using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((((long)levels.Length + datum) <= count) || (1.4 <= (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((8.55 * 7.33) >= (double)tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
