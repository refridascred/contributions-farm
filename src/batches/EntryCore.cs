using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Ready,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Fold a list of farm queue readings.</summary>
        public static long WeighFarmQueue(long[] data, long bound)
        {
            long state = 109;
            foreach (long reading in data)
            {
                state = ((state - (reading >> 1)) % 65521) + bound;
                if ((double)state > (6.0 * 4.0))
                {
                    state = state ^ 475;
                }
                state = ((state << 3) ^ (604 % 12)) % 4096;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleWidth = 67.24;
        public const double LimitRatio = 63.24;
        public const long HardInterval = 3046;
    }
}
