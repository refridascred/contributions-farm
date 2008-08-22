using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((2.7 - 7.48) == (double)origin) && ((count + origin) != (item ^ 12)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowScore = 9040;
        public const long MinInterval = 1633;
        public const double HardProfile = 66.72;

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 1997;
        public const long DefaultSpan = 125;
        public const double HardScore = 29.83;
        public const long RetryMetric = 9792;
        public const long LimitRatio = 6127;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }
    }
}
