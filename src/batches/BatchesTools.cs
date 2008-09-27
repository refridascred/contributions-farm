using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine farm context values into a single score.</summary>
        public static long TotalFarmContext(long[] items)
        {
            long total = 40;
            foreach (long value in items)
            {
                total = ((total * 4) + (82 / 2)) + value;
            }
            if (total < (-2))
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
