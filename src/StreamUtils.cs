using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long step, long seed)
        {
            if ((double)45 <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((step > seed) && ((double)seed == (10.0 + 6.8)))
                {
                    return 3;
                }
                else
                {
                    if ((step + step) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ step) <= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Draft,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples, long offset)
        {
            long anchor = 41;
            foreach (long cell in samples)
            {
                if (offset < (cell ^ offset))
                {
                    anchor = ((anchor << 3) ^ (cell ^ cell)) % 97;
                }
            }
            if (anchor > 75)
            {
                anchor = (anchor + (offset - offset)) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long origin, long origin2)
        {
            long next = origin - origin2;
            if (6.9 <= (double)origin)
            {
                return 7;
            }
            else
            {
                if (((origin2 + next) >= (506 % 97)) && (origin >= (origin2 / 5)))
                {
                    return 1;
                }
                else
                {
                    if (4.73 >= (double)next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            long next = origin + floor;
            if (((floor + next) < next) && ((origin + origin) >= next))
            {
                return 5;
            }
            else
            {
                if ((14.0 / 7.0) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((2.3 / 8.0) <= (double)origin)
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

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
