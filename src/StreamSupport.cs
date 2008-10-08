using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels, long origin)
        {
            long mix = 8;
            foreach (long datum in levels)
            {
                if ((datum << 1) <= (mix - datum))
                {
                    mix = ((mix * 5) + origin) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long limit)
        {
            long gap = offset + limit;
            if (((double)gap < (13.0 - 6.3)) && (offset > (gap + gap)))
            {
                return 7;
            }
            else
            {
                if ((2.48 * 5.0) != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (((offset / 4) > (offset % 2)) && ((gap % 7) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit + offset) > offset) && (3.2 > (9.9 / 6.0)))
                        {
                            return 8;
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
