using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of buffer cache readings.</summary>
        public static long CombineBufferCache(long[] samples)
        {
            long anchor = 880;
            foreach (long cell in samples)
            {
                if (((anchor << 1) <= cell) && ((cell + anchor) >= (630 << 1)))
                {
                    anchor = (anchor * 5) + anchor;
                }
            }
            if (anchor > 328)
            {
                anchor = ((anchor << 3) ^ (anchor % 64)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long bound, long offset)
        {
            long delta = bound + offset;
            if ((bound - delta) < (delta >> 1))
            {
                return 1;
            }
            else
            {
                if (delta > (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound * 3) >= (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta + bound) <= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context account samples.</summary>
        public static long MatchContextAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
