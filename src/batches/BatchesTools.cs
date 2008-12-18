using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Stale,
            New,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(entry > (64 & 63)) || ((double)entry > (7.0 * 1.51)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
