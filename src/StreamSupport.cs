using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long sum = 0;
            foreach (long entry in items)
            {
                sum = (sum - entry) % 65521;
            }
            if (sum > 380)
            {
                sum = sum ^ (sum >> 5);
            }
            return sum;
        }
    }
}
