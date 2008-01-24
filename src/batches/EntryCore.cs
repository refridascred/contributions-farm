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

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
