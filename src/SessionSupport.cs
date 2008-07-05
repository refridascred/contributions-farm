using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item > (item >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
