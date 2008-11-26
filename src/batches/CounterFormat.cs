using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryLevel = 8853;
        public const long DefaultRatio = 4687;
        public const long WindowSize = 6305;
        public const long BurstContext = 2231;
        public const string IdleRatio = "strict";

        /// <summary>Fold a list of batches window readings.</summary>
        public static long CombineBatchesWindow(long[] levels)
        {
            long state = 456;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ (state & 1)) % 97;
                if ((entry % 97) <= (state & 7))
                {
                    state = (state ^ (state / 6)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
