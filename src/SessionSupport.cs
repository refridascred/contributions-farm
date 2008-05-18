using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long anchor = 34;
            foreach (long item in readings)
            {
                anchor = ((anchor * 2) + anchor) - item;
            }
            if (anchor > 329)
            {
                anchor = (anchor + (anchor * 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] readings, long target)
        {
            long mix = 95;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ (entry << 2)) - target;
            }
            return mix % 97;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
