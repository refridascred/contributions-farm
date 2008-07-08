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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > 18)
                {
                    seen = ((seen + 2) + cell) + step;
                }
            }
            return seen;
        }
    }
}
