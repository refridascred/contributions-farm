using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit commits filter readings against a rule.</summary>
        public static long TallyCommitsFilterOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((189 - matches) < (floor + floor))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command route samples are out of range.</summary>
        public static long MeasureCommandRouteGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(((value * 3) <= (value + value)) && ((offset ^ value) >= (-5))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 8799;
        public const double RetryInterval = 79.53;
        public const long LimitLevel = 5791;
    }
}
