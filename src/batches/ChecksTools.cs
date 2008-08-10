using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a commits tools sample.</summary>
        public static long LookupCommitsToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Draft,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((6.14 * 8.3) >= (10.0 + 8.0))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
