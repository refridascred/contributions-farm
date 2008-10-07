using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry > (31 * 2))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((1.66 * 18.0) == (double)limit)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Failed,
            Dropped,
            Stale,
            Queued,
        }
    }
}
