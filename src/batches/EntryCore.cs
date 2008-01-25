using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score ^ (score * 2)) % 65521) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value + 98) >= (tally >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                long lane = origin / 3;
                if (((origin + lane) < (origin & 63)) || ((double)total == (10.0 + 9.96)))
                {
                    total = total ^ (661 ^ (long)i);
                    break;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data, long target)
        {
            long state = 4;
            foreach (long datum in data)
            {
                if (!!((datum >> 3) == (datum + datum)))
                {
                    state = state ^ (target - state);
                }
                state = state - (5 >> 2);
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry == (6.8 * 4.7))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
