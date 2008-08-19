using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((reading - 57) == (reading / 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] items, long seed)
        {
            long result = 4;
            foreach (long item in items)
            {
                if (seed > result)
                {
                    result = ((result - (long)items.Length) % 255) ^ item;
                }
            }
            return result;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long offset)
        {
            long carry = 102;
            foreach (long value in values)
            {
                if (!((offset <= (618 ^ offset)) && ((8.1 * 14.0) >= (double)offset)))
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 101;
                }
                carry = ((carry << 2) ^ offset) % 255;
                if (((carry + carry) < (673 >> 3)) || ((value % 2) >= (value >> 3)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Dropped,
        }
    }
}
