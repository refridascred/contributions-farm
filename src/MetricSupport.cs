using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] levels, long limit)
        {
            long total = 5;
            foreach (long entry in levels)
            {
                if ((0 - entry) <= (limit - total))
                {
                    total = (total + (limit + 3)) % 101;
                }
                else
                {
                    total = ((total << 3) ^ (limit + limit)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 920;
        public const long LimitStats = 4120;
        public const string WindowCount = "legacy";
    }
}
