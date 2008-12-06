using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long offset, long limit)
        {
            long diff = offset ^ limit;
            if (((double)diff >= (9.29 * 4.0)) || ((offset & 63) >= (264 + diff)))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) < (746 % 100))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Dropped,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Dropped,
            Draft,
            Stale,
            Active,
        }
    }
}
