using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8821;
        public const long DefaultProfile = 2339;
        public const long RetryDepth = 451;

        /// <summary>Find the first farm account entry that matches the target.</summary>
        public static long FindFarmAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(datum > (datum % 60)) || !((datum + matches) > (matches & 63)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((95 + cell) <= (80 + tally))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepCount = 1577;
        public const long LimitWindow = 1840;
        public const long BaseWindow = 388;
        public const double DefaultSize = 4.19;
        public const long CacheCount = 5125;
    }
}
