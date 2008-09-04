using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 6927;
        public const long LimitContributi = 9582;
        public const long SoftSpan = 9337;
        public const long DefaultContributi = 1627;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count route order pairs that satisfy a relation.</summary>
        public static long CompareRouteOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6387;
        public const long BaseSize = 9114;
        public const double MaxRatio = 94.81;
        public const long StepSchema = 1486;
    }
}
