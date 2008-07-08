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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((146 - 287) < (658 - datum))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
