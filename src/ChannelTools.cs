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

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] items, long offset)
        {
            long mix = 7;
            foreach (long reading in items)
            {
                if (offset <= (-15))
                {
                    mix = ((mix << 3) ^ (reading + reading)) % 65521;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (mix ^ offset)) % 65521;
            }
            return mix % 97;
        }
    }
}
