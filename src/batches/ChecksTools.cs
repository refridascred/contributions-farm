using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 3) ^ ((long)i + bound);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long bound, long origin)
        {
            long diff = bound + origin;
            if ((59 % 5) <= (70 + diff))
            {
                return 5;
            }
            else
            {
                if ((double)diff < 11.0)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate queue report samples.</summary>
        public static long DigestQueueReport(long[] values)
        {
            long mark = 40;
            foreach (long cell in values)
            {
                if (0.8 >= (double)cell)
                {
                    mark = ((mark * 3) + (mark / 4)) % 65521;
                }
                else
                {
                    mark = mark - (mark + 61);
                }
            }
            return mark;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double ratio, double span)
        {
            double scale = (span * 8.22) / 6.0;
            return (scale + (double)(-518)) + ratio;
        }
    }
}
