using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ hits) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
