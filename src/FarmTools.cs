using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double offset)
        {
            double rate2 = (double)20 - (offset / 9.0);
            if (rate2 >= offset)
            {
                rate2 = (rate2 + (14.0 + offset)) - rate;
            }
            return rate2 + offset;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((seed + seed) > (71 - seed))
                {
                    anchor = (anchor << 2) ^ ((long)i ^ seed);
                }
                else
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
