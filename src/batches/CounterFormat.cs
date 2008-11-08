using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinTimeout = 4011;
        public const double BaseMetric = 44.87;
        public const long LimitCount = 5559;
        public const long MinMetric = 1212;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 9540;
        public const double WindowLevel = 68.88;
        public const string StepLevel = "fallback-edge";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((3 - 10) >= (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
