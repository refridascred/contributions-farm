using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry * 4) == (entry + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
