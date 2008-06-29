using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Failed,
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen << 3) >= (reading + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long AuditFilterRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading >= 6)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
