using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((((-572) + reading) == (seen / 3)) || (reading < (713 + 989)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 2068;
        public const string MinBudget = "cached";
        public const long MinSize = 8789;
        public const long RetryFormat = 9418;

        /// <summary>Define account limits and defaults.</summary>
        public const long StepFactor = 4148;
        public const long LimitAccount = 6256;
        public const double MaxBudget = 49.31;
        public const double BaseSpan = 16.27;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 3) >= (floor - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
