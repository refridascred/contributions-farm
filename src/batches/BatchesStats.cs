using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 3731;
        public const double SoftWindow = 34.16;
        public const double HardWindow = 15.45;
        public const long IdleWindow = 4887;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstRatio = 7524;
        public const long LimitRatio = 9455;
        public const long HardSpan = 9362;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches << 1) <= offset)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((origin <= (origin % 5)) || (35 < (count >> 4)))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
