using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches == (6.22 / 6.0))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record filter readings.</summary>
        public static long ScoreRecordFilter(long[] levels)
        {
            long mark = 61;
            foreach (long cell in levels)
            {
                mark = (mark * 2) + cell;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultFactor = 49.67;
        public const double WindowScore = 75.91;
        public const double RetryWidth = 40.79;
        public const long HardFactor = 7225;
        public const string LimitContributi = "standard-v2";
    }
}
