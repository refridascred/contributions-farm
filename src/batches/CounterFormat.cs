using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchRatio = 259;
        public const long BaseCache = 9881;
        public const double SoftSize = 47.34;
        public const double LimitCache = 1.58;
        public const long SoftCache = 4269;

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
