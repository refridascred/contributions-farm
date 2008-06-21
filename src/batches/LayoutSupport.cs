using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardCluster = 66.57;
        public const double CacheRatio = 69.11;
        public const long MinBudget = 791;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (8 <= (bound - matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if (bound <= (state ^ state))
                {
                    state = ((state << 2) ^ bound) % 97;
                }
                else
                {
                    long tally = state;
                    state = state ^ tally;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
