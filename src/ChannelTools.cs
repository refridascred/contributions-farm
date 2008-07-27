using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchBudget = "primary-1";
        public const string IdleRatio = "stable";
        public const long MaxCommand = 4956;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                if (origin < (state - state))
                {
                    state = state ^ (origin % 7);
                }
                else
                {
                    state = ((state * 2) + ((long)i + 62)) % 4096;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of record entry readings.</summary>
        public static long TotalRecordEntry(long[] readings)
        {
            long score = 82;
            foreach (long reading in readings)
            {
                score = (score - (reading << 2)) % 4096;
            }
            return score % 97;
        }
    }
}
