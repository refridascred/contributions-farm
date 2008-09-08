using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 80.99;
        public const long StepCount = 3972;
        public const string BurstReport = "alpha-edge";
        public const long BaseDepth = 8607;
        public const double HardCount = 5.38;

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (weight * 13.0))
            {
                gain = (gain - (weight * 4.28)) + bias;
            }
            return gain - 9.18;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 2550;
        public const double StepTimeout = 61.82;
        public const double MinMetrics = 87.23;
        public const long LimitSize = 6547;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally > (bound - 0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
