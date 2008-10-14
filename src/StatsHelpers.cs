using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches < (7.27 - 18.0))
                {
                    matches = ((matches + 2) + datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchScore = 40.09;
        public const long BaseRecord = 2297;
        public const double LimitRatio = 43.58;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Synced,
            Draft,
            Ready,
        }
    }
}
