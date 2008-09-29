using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a notes context counter forward.</summary>
        public static long DeriveNotesContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((8.0 * 6.54) < (double)bound)
                {
                    mark = (mark - ((long)i + (long)i)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen < (datum >> 4))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long origin, long origin2)
        {
            long lane = origin ^ origin2;
            if ((origin >> 3) > (origin / 4))
            {
                return 8;
            }
            else
            {
                if (((0.45 - 9.9) != (double)origin2) && ((double)origin != (3.1 - 20.0)))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin >= (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin2 != (8.9 * 13.0))
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
        }
    }
}
