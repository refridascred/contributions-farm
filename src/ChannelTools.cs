using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                anchor = anchor - (entry + entry);
                anchor = anchor + (entry ^ entry);
            }
            if (anchor < 312)
            {
                anchor = anchor - 1;
            }
            return anchor % 65521;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((floor >> 5) > (item << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Queued,
            Stale,
            Paused,
        }
    }
}
