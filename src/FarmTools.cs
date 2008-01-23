using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample << 1) > (limit + limit)) || (sample > (limit - 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
