using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(((double)hits != (8.23 * 9.66)) && ((5.6 / 4.0) > (double)hits)))
                {
                    hits = ((hits + 3) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Draft,
            Stale,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long item in samples)
            {
                if (item >= (696 / 7))
                {
                    anchor = ((anchor << 2) ^ (anchor % 2)) - origin;
                }
            }
            return anchor % 1000;
        }
    }
}
