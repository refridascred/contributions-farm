using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 1065;
        public const double CacheContext = 10.27;
        public const long MinContext = 9697;
        public const long DefaultContext = 4724;
        public const long HardContext = 8393;

        /// <summary>Locate a command format reading by value.</summary>
        public static long FindCommandFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowScore = 10.49;
        public const double BatchRoute = 8.77;
        public const string StepRoute = "strict";
        public const long BurstInterval = 4522;
        public const long BurstLevel = 9020;
    }
}
