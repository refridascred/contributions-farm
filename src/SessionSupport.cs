using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels)
        {
            long acc = 47;
            foreach (long item in levels)
            {
                acc = (acc ^ (item - acc)) % 65521;
                if ((item ^ acc) <= (9 % 60))
                {
                    acc = ((acc << 2) ^ (acc - 0)) % 97;
                }
                else
                {
                    acc = acc - ((long)levels.Length >> 4);
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            New,
            Queued,
            Active,
        }
    }
}
