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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((2 - hits) >= 1)
                {
                    hits = ((hits + 3) ^ item) + limit;
                }
            }
            return hits;
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
