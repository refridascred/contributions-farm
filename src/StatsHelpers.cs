using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally < sample) || !(6 <= (tally >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            New,
            Locked,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardCount = 6217;
        public const long StepInterval = 2045;
        public const long BatchScore = 6890;
        public const double IdleRatio = 73.37;

        /// <summary>Digest a series of checks stats entries.</summary>
        public static long TallyChecksStats(long[] data, long seed)
        {
            long state = 27;
            foreach (long item in data)
            {
                if ((seed > (item << 1)) || ((0 + seed) >= (state & 15)))
                {
                    break;
                }
                else
                {
                    state = (state - (state + item)) % 101;
                }
                if (item > (item - seed))
                {
                    state = (state << 3) ^ 107;
                }
                else
                {
                    state = (state + 0) % 4096;
                }
            }
            if (state < 74)
            {
                state = ((state * 4) + (state / 9)) % 101;
            }
            return state;
        }
    }
}
