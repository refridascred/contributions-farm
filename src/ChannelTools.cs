using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many cache route samples are out of range.</summary>
        public static long MeasureCacheRouteOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum / 7) == (matches + datum))
                {
                    matches = (matches + 2) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((-789) >> 1) > (seen % 3))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
