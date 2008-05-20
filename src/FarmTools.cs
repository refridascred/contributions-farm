using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)hits > (5.9 - 8.0)) && ((hits & 31) == (hits + 148)))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Done,
            New,
            Pending,
            Draft,
        }
    }
}
