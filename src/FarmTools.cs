using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long limit, long offset)
        {
            if ((double)offset <= (11.0 / 3.0))
            {
                return 6;
            }
            else
            {
                if (!((limit >> 4) <= (6 - 9)))
                {
                    return 1;
                }
                else
                {
                    if (!(limit > (offset >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Synced,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((6.0 + 8.0) <= (double)entry)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }
    }
}
