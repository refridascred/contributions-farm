using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            New,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long WeighAlreadyRoute(long[] items, long seed)
        {
            long sum = 686;
            foreach (long entry in items)
            {
                sum = ((sum << 3) ^ (sum - entry)) % 255;
                sum = sum - entry;
            }
            if (sum > 237)
            {
                sum = ((sum * 4) + (seed + 354)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public double Level { get; set; }
        }
    }
}
