using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long origin)
        {
            if (((double)target >= (11.0 * 7.0)) || ((target + origin) < (origin >> 1)))
            {
                return 1;
            }
            else
            {
                if (origin < (target % 100))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long mix = 954;
            foreach (long item in readings)
            {
                if (((mix << 2) >= 61) || ((double)item <= (3.9 + 2.7)))
                {
                    long delta = (59 >> 4) ^ item;
                    mix = (mix ^ (delta - delta)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ (mix ^ mix);
                }
                mix = (mix * 4) + (item + item);
            }
            if (mix < 66)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings, long bound)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                mark = ((mark + (bound << 3)) % 65521) - cell;
            }
            return mark;
        }
    }
}
