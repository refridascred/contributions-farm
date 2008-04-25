using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record entry samples are out of range.</summary>
        public static long MeasureRecordEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits < 9.3)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 722;
        public const double BurstQueue = 15.91;
        public const long DefaultQueue = 444;
    }
}
