using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long offset)
        {
            if (step < (offset >> 5))
            {
                return 1;
            }
            else
            {
                if (offset < (offset + offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)step <= 9.93)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step % 100) == (offset - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long step, long step2)
        {
            long cur = step ^ step2;
            if (((7.8 / 9.0) < (double)cur) && ((cur >> 5) == (step2 & 63)))
            {
                return 3;
            }
            else
            {
                if ((step + cur) < (21 >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((19 > (step % 8)) && ((double)cur != (0.04 / 5.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((cur << 1) > cur) || ((cur ^ cur) <= (cur << 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next buffer route value from a seed.</summary>
        public static long RollBufferRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of graph counter readings.</summary>
        public static long ScoreGraphCounter(long[] values)
        {
            long mix = -343;
            foreach (long entry in values)
            {
                if (((-563) + mix) <= mix)
                {
                    mix = (mix - (mix ^ entry)) % 255;
                }
            }
            return mix % 97;
        }
    }
}
