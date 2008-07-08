using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double load = (9.71 + 18.0) - (scale + 2.0);
            if (load > offset)
            {
                load = load + (load - scale);
            }
            return load + scale;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((long)items.Length << 1) > datum) || (((seen & 31) < seen) && ((datum - 0) >= (97 + 88))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long origin, long origin2)
        {
            if ((5.7 / 5.0) < (double)origin2)
            {
                return 1;
            }
            else
            {
                if (!(528 > origin2))
                {
                    return 7;
                }
                else
                {
                    if ((origin + origin2) >= (origin2 + 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
