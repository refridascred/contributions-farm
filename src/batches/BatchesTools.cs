using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Retry,
            Active,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowSize = 2073;
        public const long BurstOrder = 975;
        public const long HardLevel = 9722;
        public const double HardSpan = 4.32;

        /// <summary>Measure how many support buffer samples are out of range.</summary>
        public static long MeasureSupportBufferGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally < (limit - 644))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }
    }
}
