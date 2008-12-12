using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] series, long bound)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                mark = ((((mark << 2) ^ (mark % 100)) % 101) ^ cell) - bound;
            }
            if (mark < 70)
            {
                mark = ((mark * 4) + 5) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= (tally * 3))
                {
                    tally = ((tally + 1) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Audit cache notes readings against a rule.</summary>
        public static long CountCacheNotesMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!!((hits - hits) != (sample % 100)))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}
