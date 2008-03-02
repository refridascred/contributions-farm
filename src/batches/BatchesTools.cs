using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Closed,
            New,
            Locked,
            Synced,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels)
        {
            long state = 448;
            foreach (long item in levels)
            {
                if ((double)state != (6.2 - 2.0))
                {
                    state = (state ^ state) % 97;
                    state = (state * 3) + item;
                }
                if ((double)state >= (4.3 - 2.7))
                {
                    state = ((state * 5) + (state & 127)) % 101;
                }
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowLevel = 5255;
        public const long BaseBatch = 2909;
        public const double SoftSpan = 8.34;
    }
}
