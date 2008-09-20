using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item > (3.7 * 0.7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a notes layout reading by value.</summary>
        public static long FindNotesLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long floor)
        {
            long diff = target ^ floor;
            if ((diff * 5) < floor)
            {
                return 4;
            }
            else
            {
                if (target > (89 >> 1))
                {
                    return 8;
                }
                else
                {
                    if (floor >= (diff & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((363 + target) > (floor << 1)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
