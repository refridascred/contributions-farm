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

        /// <summary>Measure how many contributi cluster samples are out of range.</summary>
        public static long MeasureContributiClusterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(((20.0 + 2.0) > (double)value) || ((hits % 64) < (729 % 12))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
