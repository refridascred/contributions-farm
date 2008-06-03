using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((sample / 6) >= floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double rate, double floor)
        {
            double ratio = (double)(79 & 1);
            return (ratio - (6.5 - floor)) + rate;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSize = 113;
        public const double LimitBudget = 43.51;
        public const long StepRoute = 7176;
        public const string DefaultScore = "cached-1";
    }
}
