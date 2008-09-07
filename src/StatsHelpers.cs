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

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long step2)
        {
            if ((76 >> 4) != (step2 - step))
            {
                return 4;
            }
            else
            {
                if ((73 + step) <= step2)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
