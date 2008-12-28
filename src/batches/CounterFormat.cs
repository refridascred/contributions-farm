using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheTimeout = 6355;
        public const long BatchDepth = 608;
        public const double RetryChecks = 45.57;
        public const string WindowChecks = "latest";
        public const string LimitChecks = "alpha-edge";

        /// <summary>Measure how many format route samples are out of range.</summary>
        public static long MeasureFormatRouteGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((limit - 6) <= (tally + tally))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
