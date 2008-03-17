using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values)
        {
            long carry = 0;
            foreach (long item in values)
            {
                carry = (carry << 2) ^ (item - item);
                if (item <= (item + carry))
                {
                    break;
                }
            }
            if (carry > 18)
            {
                carry = ((carry << 3) ^ (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels)
        {
            long acc = 270;
            foreach (long entry in levels)
            {
                if (!((entry + acc) > (970 + entry)))
                {
                    acc = (acc << 3) ^ (entry - acc);
                }
                else
                {
                    acc = ((acc * 5) + (entry + entry)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)bound >= (double)31)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (total & 255)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
