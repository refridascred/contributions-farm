using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits > (8.0 - 8.0))
                {
                    hits = ((hits + 1) + datum) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
