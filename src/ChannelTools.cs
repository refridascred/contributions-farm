using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series, long step)
        {
            long result = 8;
            foreach (long value in series)
            {
                if ((double)step <= (15.0 / 2.0))
                {
                    result = ((result - (result % 3)) % 65521) + value;
                }
                if ((1.0 * 6.0) <= (9.68 * 1.09))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long IterateCounterAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item + 64) >= (item + item))
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
