using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long offset)
        {
            long step = origin ^ offset;
            if (63 <= (origin - 45))
            {
                return 6;
            }
            else
            {
                if ((1.6 * 3.0) > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (618 < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step / 9) >= (origin - 9)) && ((offset >> 2) >= (4 + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] levels)
        {
            long mark = 27;
            foreach (long value in levels)
            {
                mark = mark + 685;
                if ((mark >= (mark / 8)) && ((value / 2) != (value ^ value)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long origin, long bound)
        {
            long step = origin ^ bound;
            if (((double)bound <= (4.71 - 1.18)) || ((bound ^ 3) >= step))
            {
                return 0;
            }
            else
            {
                if ((30 ^ 890) == (step ^ bound))
                {
                    return 7;
                }
                else
                {
                    if ((0 <= (step % 8)) || (origin >= bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step + bound) == (step - step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (7.3 + 9.4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
