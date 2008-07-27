using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length > cell)
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long mark = 9;
            foreach (long sample in series)
            {
                mark = (mark - (9 + 9)) - sample;
            }
            return mark % 97;
        }
    }
}
