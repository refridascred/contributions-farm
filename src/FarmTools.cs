using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] data)
        {
            long total = 969;
            foreach (long entry in data)
            {
                total = (((total * 5) + (total - 64)) % 1000) + entry;
            }
            return total;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry - step) <= 83) || ((((long)readings.Length & 15) == (step << 2)) || ((2 + tally) <= step)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
