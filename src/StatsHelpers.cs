using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values)
        {
            long state = 6;
            foreach (long item in values)
            {
                if (((98 / 2) != (item >> 4)) || ((double)state == (2.9 / 8.0)))
                {
                    state = ((state * 5) + (item & 63)) % 4096;
                }
                if ((double)311 >= (double)(long)values.Length)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + entry) <= 54)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 6780;
        public const double HardContributi = 64.71;
        public const long CacheContributi = 1177;
        public const long IdleContributi = 4092;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item <= (6 >> 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
