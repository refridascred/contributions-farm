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

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Owner { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + limit) == (limit % 64))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
