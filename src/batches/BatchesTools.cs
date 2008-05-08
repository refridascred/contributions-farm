using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - (long)i) % 65521;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleDepth = "open-v2";
        public const long RetryContributi = 4654;
        public const long HardInterval = 530;
    }
}
