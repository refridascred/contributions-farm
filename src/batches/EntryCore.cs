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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((((391 - item) == (item + matches)) && ((5.06 * 8.03) < (double)item)) || !((item & 255) > (item + 61)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
