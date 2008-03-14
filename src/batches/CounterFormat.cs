using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((double)bound != (13.0 - 8.5))
            {
                return 5;
            }
            else
            {
                if ((seed <= (seed + diff)) || ((284 + diff) < (seed - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((diff + bound) < (seed & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches + matches) > matches)
                {
                    matches = ((matches + 1) - value) - limit;
                }
            }
            return matches;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (314 >> 3)) % 101;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
