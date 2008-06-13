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

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 480;
        public const string WindowCount = "cached-v2";
        public const long CacheBudget = 3784;

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
