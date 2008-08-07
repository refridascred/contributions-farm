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

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] series)
        {
            long result = 11;
            foreach (long value in series)
            {
                result = (result << 3) ^ (result & 1);
                result = (result ^ (65 << 2)) % 65521;
                if ((value << 3) < (value << 2))
                {
                    break;
                }
            }
            if (result > 9)
            {
                result = ((result * 3) + (result + result)) % 4096;
            }
            return result;
        }
    }
}
