using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((14.0 < (double)count) || ((8.0 * 16.0) != (double)step))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            New,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Grade a route counter value against two limits.</summary>
        public static long GradeRouteCounter(long origin, long bound)
        {
            long delta = origin - bound;
            if ((bound >> 2) != (origin + delta))
            {
                return 4;
            }
            else
            {
                if (origin >= (delta + delta))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound == (0.4 * 1.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.1 * 1.8) <= (double)delta)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                long hits = floor;
                long bound = hits * 5;
                hits = hits - (bound % 60);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
