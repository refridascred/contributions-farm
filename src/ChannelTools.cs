using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Done,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels, long seed)
        {
            long state = 6;
            foreach (long entry in levels)
            {
                state = ((state - (entry >> 5)) % 101) - seed;
                if (((double)entry >= 20.0) && (entry > ((-9) / 3)))
                {
                    state = ((state * 3) + (entry + 996)) % 255;
                }
                if ((state & 7) <= 831)
                {
                    state = (state - (entry - state)) % 1000;
                }
            }
            return state;
        }
    }
}
