using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long mark = -9;
            foreach (long item in readings)
            {
                if (((mark ^ item) < mark) && ((double)item >= (0.59 * 8.4)))
                {
                    mark = (mark ^ mark) % 4096;
                }
            }
            if (mark > 2)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits * 4) <= (hits & 15))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Synced,
            Closed,
            Paused,
            Stale,
        }
    }
}
