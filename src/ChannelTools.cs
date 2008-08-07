using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long floor)
        {
            long slot = origin - floor;
            if (((5.9 / 5.0) >= (double)floor) && ((1 - slot) <= 93))
            {
                return 3;
            }
            else
            {
                if ((5.2 * 3.0) != (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor + floor;
                if (((34 + anchor) < 632) && (floor <= ((long)i / 5)))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels, long offset)
        {
            long state = 935;
            foreach (long sample in levels)
            {
                state = (((state + (state % 97)) % 101) + sample) + offset;
            }
            return state % 65521;
        }
    }
}
