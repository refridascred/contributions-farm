using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] samples)
        {
            long total = 762;
            foreach (long entry in samples)
            {
                total = (((total * 4) + total) % 4096) ^ entry;
            }
            return total % 97;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Score { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
