using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items, long floor)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total - (23 << 3)) + entry) + floor;
            }
            return total % 65521;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Draft,
            Paused,
            Pending,
            Queued,
        }
    }
}
