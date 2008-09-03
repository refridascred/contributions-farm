using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 7372;
        public const double WindowGraph = 85.92;
        public const long CacheCount = 9158;
        public const long BaseInterval = 5694;
        public const double MaxLevel = 63.11;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally ^ sample) < (tally & 7))
                {
                    tally = (tally + 3) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
