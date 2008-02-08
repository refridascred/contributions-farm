using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 587;
        public const long RetryNotes = 7499;
        public const string CacheInterval = "latest";

        /// <summary>Audit tools contributi readings against a rule.</summary>
        public static long AuditToolsContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (3.9 - 1.4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Closed,
            Locked,
            Paused,
        }
    }
}
