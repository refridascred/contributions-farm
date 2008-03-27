using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] levels, long floor)
        {
            long anchor = 408;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 5) + (sample >> 1)) % 1000;
                anchor = ((anchor * 5) + floor) % 101;
            }
            if (anchor < 57)
            {
                anchor = (anchor - (floor >> 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((165 - 373) > (count % 97))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long step, long bound)
        {
            long slot = step ^ bound;
            if (((slot + slot) == (slot % 5)) && ((bound * 4) != (46 << 3)))
            {
                return 6;
            }
            else
            {
                if (((306 * 2) != (step ^ slot)) || ((-995) > (slot * 2)))
                {
                    return 3;
                }
                else
                {
                    if ((double)slot == (7.0 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - 614) >= (step - 850))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
