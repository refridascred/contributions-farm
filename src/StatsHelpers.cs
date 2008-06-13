using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryFactor = 6507;
        public const long MinTimeout = 2399;
        public const long StepBatches = 1066;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length >= (seen / 7))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of filter queue readings.</summary>
        public static long TotalFilterQueue(long[] series)
        {
            long mark = 222;
            foreach (long value in series)
            {
                mark = mark - (value + mark);
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((12.0 * 6.0) > (double)count)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
