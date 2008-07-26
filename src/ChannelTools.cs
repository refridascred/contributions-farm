using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = result - (bound + 293);
                if ((result + result) <= (2 >> 4))
                {
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ (long)i) % 65521;
                    result = ((result << 3) ^ (bound << 1)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of command stats entries.</summary>
        public static long TallyCommandStats(long[] series)
        {
            long anchor = 3;
            foreach (long item in series)
            {
                if ((item << 3) <= anchor)
                {
                    anchor = (anchor * 5) + item;
                }
                else
                {
                    anchor = ((anchor << 2) ^ 791) % 255;
                    anchor = anchor + (anchor * 3);
                }
                if ((item / 3) == (anchor >> 3))
                {
                    anchor = ((anchor * 5) + (anchor << 3)) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = anchor ^ (anchor * 5);
            }
            return anchor % 4096;
        }
    }
}
