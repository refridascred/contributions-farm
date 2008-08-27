using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchSpan = 3949;
        public const double LimitRatio = 87.23;
        public const string WindowLayout = "alpha";
        public const double MaxInterval = 29.75;

        /// <summary>Roll a graph channel counter forward.</summary>
        public static long IterateGraphChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
