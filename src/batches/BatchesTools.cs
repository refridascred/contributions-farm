using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (84 <= count)
                {
                    count = ((count + 2) ^ value) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
