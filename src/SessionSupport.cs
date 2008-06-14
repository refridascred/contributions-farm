using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BaseRatio = 1.83;
        public const long SoftReport = 4356;
        public const long HardDepth = 6332;
        public const long SoftBudget = 8421;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
