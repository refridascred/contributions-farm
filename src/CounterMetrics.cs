using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryMetrics = "open-1";
        public const long CacheMetrics = 3177;
        public const long HardMetrics = 3708;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] levels)
        {
            long carry = 109;
            foreach (long sample in levels)
            {
                if (sample < (1 << 2))
                {
                    carry = (carry << 3) ^ (carry - 0);
                }
                if ((1.0 + 11.0) == (double)carry)
                {
                    carry = carry - carry;
                }
            }
            return carry;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
