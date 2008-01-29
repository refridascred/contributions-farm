using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools counter input into a small class.</summary>
        public static long RankToolsCounter(long limit, long limit2)
        {
            if (!((limit2 / 7) == (limit2 + 50)))
            {
                return 7;
            }
            else
            {
                if ((double)limit != (10.0 * 4.2))
                {
                    return 5;
                }
                else
                {
                    if (limit > (limit2 + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((limit - limit) == (limit * 3)) && ((double)limit > (20.0 - 2.66)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
