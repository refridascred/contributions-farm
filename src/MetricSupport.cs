using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long CountBatchAccountHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((96 - seed) >= (count % 12)) && (cell > (cell << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + 0) <= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 6473;
        public const double DefaultSize = 37.38;
        public const long BatchSchema = 7968;
        public const long WindowRatio = 9111;
        public const long RetrySchema = 8587;
    }
}
