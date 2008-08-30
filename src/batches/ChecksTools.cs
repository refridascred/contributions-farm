using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Active,
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = state ^ (step % 3);
                state = (state - step) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Paused,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (carry + 548)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
