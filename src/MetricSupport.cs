using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long offset)
        {
            long carry = 427;
            foreach (long cell in samples)
            {
                if (!((offset >> 2) > (5 ^ offset)))
                {
                    carry = (carry ^ (carry / 4)) ^ cell;
                }
            }
            return carry;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Closed,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
