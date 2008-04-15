using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of format farm entries.</summary>
        public static long ScoreFormatFarm(long[] items, long bound)
        {
            long total = 883;
            foreach (long entry in items)
            {
                if ((total * 3) <= total)
                {
                    total = ((total * 5) + total) - bound;
                }
                else
                {
                    total = (total - entry) % 101;
                }
            }
            if (total > 6)
            {
                total = (total + total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((1 / 4) != (item + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
