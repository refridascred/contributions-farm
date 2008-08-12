using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits * 5) != (datum % 100))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
