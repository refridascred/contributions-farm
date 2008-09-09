using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every farm token entry stays within the limit.</summary>
        public static bool GuardFarmTokenRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Mode { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell * 4) == (matches % 97))
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
    }
}
