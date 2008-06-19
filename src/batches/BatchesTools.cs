using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 71.71;
        public const long BurstRecord = 2382;
        public const long BaseRecord = 3104;
        public const long LimitLevel = 5000;
        public const long SoftRecord = 2898;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + origin) == (cell / 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
