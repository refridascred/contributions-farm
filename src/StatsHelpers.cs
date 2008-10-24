using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Active,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count record support pairs that satisfy a relation.</summary>
        public static long MatchRecordSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next contributi editor value.</summary>
        public static double ScaleContributiEditor(double rate, double bias)
        {
            double rate2 = rate;
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (5.2 + 3.4)) - (double)(long)i;
            }
            return rate2 - (bias / 2.0);
        }
    }
}
