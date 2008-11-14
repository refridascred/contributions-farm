using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of order checks readings.</summary>
        public static long CombineOrderChecks(long[] series)
        {
            long anchor = 8;
            foreach (long value in series)
            {
                anchor = ((anchor + (anchor << 3)) % 65521) - value;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
