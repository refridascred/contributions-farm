using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a metrics payload value against two limits.</summary>
        public static long GradeMetricsPayload(long seed, long step)
        {
            if ((seed > (step + step)) || (((-94) % 8) > step))
            {
                return 1;
            }
            else
            {
                if ((seed - step) <= (seed + seed))
                {
                    return 7;
                }
                else
                {
                    if (step > (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step - step) < (190 & 1)) && ((double)seed != (3.0 - 12.0)))
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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                bool found = anchor >= ((-82) * 4);
                if (found)
                {
                    found = (anchor * 3) <= offset;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series)
        {
            long carry = 91;
            foreach (long value in series)
            {
                carry = (carry ^ (value % 12)) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a buffer record counter forward.</summary>
        public static long IterateBufferRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((6.15 + 0.79) > (double)origin)
                {
                    state = state + origin;
                }
                if (state > (state >> 2))
                {
                    break;
                }
                else
                {
                    state = ((state << 2) ^ origin) % 1000;
                    state = (state + (origin % 2)) % 255;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels, long limit)
        {
            long mix = -53;
            foreach (long entry in levels)
            {
                if (!((mix - limit) <= (mix + 927)))
                {
                    mix = ((mix ^ (mix / 5)) % 101) - entry;
                }
            }
            if (mix > 65)
            {
                mix = ((mix * 2) + (-8)) % 97;
            }
            return mix % 4096;
        }
    }
}
