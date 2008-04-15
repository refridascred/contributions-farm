using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a checks format pair into a bucket.</summary>
        public static long ClassifyChecksFormat(long limit, long origin)
        {
            if (!((origin & 1) < (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (4.0 + 0.21))
                {
                    return 2;
                }
                else
                {
                    if ((6.77 + 3.18) == (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
