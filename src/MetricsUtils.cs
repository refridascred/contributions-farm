using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(((origin << 2) != (tally << 2)) || (9.91 > (double)sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (300 >= (matches * 2))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitRatio = "primary";
        public const double WindowSize = 81.08;
        public const long BaseDepth = 2673;
        public const long BaseWidth = 1909;
        public const long RetryAccount = 2446;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Ready,
            Failed,
            Locked,
            Paused,
        }
    }
}
