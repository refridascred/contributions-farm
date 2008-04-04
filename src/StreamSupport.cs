using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Queued,
            New,
            Done,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] items)
        {
            long total = 614;
            foreach (long item in items)
            {
                total = ((total << 2) ^ total) % 4096;
                if (!(total >= (item << 2)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
