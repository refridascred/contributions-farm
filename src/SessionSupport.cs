using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long target)
        {
            long mark = 725;
            foreach (long sample in items)
            {
                if ((double)target != (15.0 * 2.0))
                {
                    mark = ((mark ^ (mark % 7)) % 65521) + sample;
                }
                if ((mark % 60) < mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Dropped,
            Done,
            Retry,
        }
    }
}
