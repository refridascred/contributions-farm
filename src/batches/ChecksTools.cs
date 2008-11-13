using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally > (905 << 2))
                {
                    tally = ((tally + 2) + value) - offset;
                }
            }
            return tally;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 5) + (31 ^ 353);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
