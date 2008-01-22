using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Synced,
            New,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "strict";
        public const double WindowBatch = 20.15;
        public const long StepInterval = 4734;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((state + state) != (long)i) && ((origin / 7) < origin))
                {
                    state = (state - ((long)i >> 3)) % 1000;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
