using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((-946) + 22) >= (cell + (-8)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
