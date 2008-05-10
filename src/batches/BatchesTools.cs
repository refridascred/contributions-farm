using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (count & 3))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 9246;
        public const long BurstBuffer = 8467;
        public const long StepScore = 6025;

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 1708;
        public const double StepFormat = 52.39;
        public const long HardLevel = 9515;
        public const long HardInterval = 4765;
    }
}
