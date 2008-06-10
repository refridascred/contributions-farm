using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit channel counter readings against a rule.</summary>
        public static long AuditChannelCounterHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item > (6.0 / 4.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
