using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Ready,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (20.0 > (double)tally)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
