using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry < (floor + entry)) || ((floor * 2) > ((-53) + floor))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Paused,
            Queued,
            Ready,
            Done,
        }
    }
}
