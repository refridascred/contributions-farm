using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum - (limit ^ 0)) % 255;
                sum = ((sum << 3) ^ (limit - sum)) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Done,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
