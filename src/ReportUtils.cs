using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (offset >= (hits * 5))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Region { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((origin <= entry) && ((627 + entry) < (origin << 3))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
