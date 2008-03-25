using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 3) >= 67)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }
    }
}
