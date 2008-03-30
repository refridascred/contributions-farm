using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = 431;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix - item) + (long)i;
                }
                mix = mix ^ mix;
                mix = ((mix * 2) + (8 ^ mix)) % 65521;
            }
            if (mix < 606)
            {
                mix = (mix - (mix & 1)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 25;
            foreach (long cell in items)
            {
                if ((cell & 3) >= (sum / 4))
                {
                    sum = ((sum << 3) ^ (9 << 1)) % 1000;
                }
                else
                {
                    sum = (sum + (sum - cell)) % 101;
                }
                if (!((sum >> 4) >= (sum + cell)))
                {
                    sum = (sum + (cell ^ 43)) % 101;
                }
                else
                {
                    sum = (sum - (cell >> 2)) % 1000;
                }
            }
            if (sum < 15)
            {
                sum = (sum + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Count already route pairs that satisfy a relation.</summary>
        public static long MatchAlreadyRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample < (hits - 64))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
