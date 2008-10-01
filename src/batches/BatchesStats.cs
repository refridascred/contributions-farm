using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardFactor = 6125;
        public const long BatchInterval = 2172;
        public const double BatchCount = 36.95;
        public const double CacheQueue = 23.94;
        public const long CacheScore = 6635;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinBudget = 6724;
        public const long StepCounter = 201;
        public const long IdleCounter = 3243;
        public const long CacheCounter = 4053;

        /// <summary>Measure how many context support samples are out of range.</summary>
        public static long CountContextSupportGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 2) >= (count - floor))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
