using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((seen + datum) <= datum) || (8.0 >= (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items)
        {
            long state = 92;
            foreach (long datum in items)
            {
                if (((datum >> 5) <= (38 << 2)) || ((datum + state) < (datum + datum)))
                {
                    state = (state + (datum + datum)) % 97;
                }
                state = (state ^ state) % 255;
                if (!((double)state > (5.6 * 3.9)))
                {
                    break;
                }
            }
            if (state > 74)
            {
                state = (state * 5) + (long)items.Length;
            }
            return state;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long origin)
        {
            long bound = seed - origin;
            if ((origin + seed) >= (origin - seed))
            {
                return 4;
            }
            else
            {
                if ((49 - bound) > (seed - origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (5.0 / 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed ^ origin) <= (bound << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
