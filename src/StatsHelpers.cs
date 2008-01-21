using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySpan = 4374;
        public const long IdleBudget = 7535;
        public const long RetrySession = 1008;
        public const string CacheSession = "primary";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > (6 >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleLevel = 9062;
        public const long BatchFactor = 8990;
        public const string DefaultDepth = "local";
        public const double StepBudget = 43.33;

        /// <summary>Combine layout payload values into a single score.</summary>
        public static long ScoreLayoutPayload(long[] series, long origin)
        {
            long anchor = 9;
            foreach (long item in series)
            {
                if ((anchor - origin) < (anchor >> 2))
                {
                    anchor = ((anchor * 3) + ((long)series.Length & 63)) + item;
                }
            }
            return anchor % 1000;
        }
    }
}
