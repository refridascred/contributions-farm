using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Closed,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Roll a cache notes counter forward.</summary>
        public static long DeriveCacheNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result ^ step) % 101;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryCount = 3365;
        public const long DefaultCount = 7490;
        public const double BaseBudget = 86.44;

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchWidth = 88.31;
        public const long WindowSession = 6120;
        public const double BurstSpan = 4.2;
        public const long DefaultSize = 8261;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
