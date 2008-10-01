using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double ratio2 = (double)3 - 12.0;
            return (ratio2 + span) + ratio;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - (limit & 255)) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long anchor = 341;
            foreach (long datum in series)
            {
                if ((((-490) ^ datum) < (datum + datum)) || ((double)anchor != (9.15 * 17.0)))
                {
                    anchor = (anchor ^ 80) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor % 5)) % 1000;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor % 4096;
        }
    }
}
