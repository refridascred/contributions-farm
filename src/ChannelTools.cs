using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((offset + 227) >= (offset2 - offset2))
            {
                return 0;
            }
            else
            {
                if (((offset2 & 7) != (offset + offset2)) && ((offset + 27) >= (6 + origin)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long seed, long floor)
        {
            long prev = seed - floor;
            if ((prev ^ floor) == (floor % 100))
            {
                return 1;
            }
            else
            {
                if ((1.58 * 8.4) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)floor < (1.0 * 8.34))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)floor == (double)prev))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] values)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                anchor = (anchor - (anchor - item)) % 101;
                if (anchor > (65 << 1))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
