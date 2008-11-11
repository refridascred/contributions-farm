using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] values)
        {
            long state = 59;
            foreach (long value in values)
            {
                state = state ^ value;
            }
            if (state < (-5))
            {
                state = (state ^ (7 + state)) % 101;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "stable-1";
        public const double DefaultFactor = 45.46;
        public const long SoftToken = 1426;
        public const double IdleToken = 10.75;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}
