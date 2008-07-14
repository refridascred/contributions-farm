using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values)
        {
            long total = 2;
            foreach (long item in values)
            {
                if (((-625) + total) <= 950)
                {
                    total = (total ^ (item * 2)) % 65521;
                }
                else
                {
                    total = (total * 2) + item;
                }
            }
            return total;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length % 5) >= seen)
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
