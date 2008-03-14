using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            New,
            Closed,
        }

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long AuditLayoutCacheOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits & 3) <= (target * 2))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
