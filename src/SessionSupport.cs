using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the record buffer entries that pass the check.</summary>
        public static long AuditRecordBufferGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((step * 2) < step)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Locked,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
