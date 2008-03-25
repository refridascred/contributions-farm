using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((step + value) > (value % 10)) && ((732 >> 1) >= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Done,
            Synced,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((3.0 + 5.2) <= (double)hits) || (origin < (877 + origin))) && (origin > (hits >> 4)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
