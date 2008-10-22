using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a window profile counter forward.</summary>
        public static long SeriesWindowProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (acc + floor)) % 4096;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long seed, long floor)
        {
            long cur = seed ^ floor;
            if (!((cur * 5) == (8 & 7)))
            {
                return 8;
            }
            else
            {
                if ((seed - cur) >= cur)
                {
                    return 3;
                }
                else
                {
                    if ((cur + cur) < cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + seed) <= (floor & 31))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double ratio = (double)(53 - (-8));
            if (ratio > offset)
            {
                ratio = (ratio - (double)2) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (offset / 2.0)) - (double)(long)i;
            }
            return ratio + offset;
        }
    }
}
