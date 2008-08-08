using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the format record entries that pass the check.</summary>
        public static long AuditFormatRecordHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)tally <= (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
