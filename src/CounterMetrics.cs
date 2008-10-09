using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultBudget = 235;
        public const long BaseSession = 5988;
        public const long StepSession = 6859;
        public const double BurstSpan = 17.97;
        public const string BatchTimeout = "standard";

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(seen >= 54))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
