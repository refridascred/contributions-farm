using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                mix = ((mix + (long)items.Length) % 97) ^ cell;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 74.57;
        public const double WindowInterval = 57.38;
        public const long BaseBudget = 2119;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
