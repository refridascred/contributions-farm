using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] items, long limit)
        {
            long state = 642;
            foreach (long item in items)
            {
                if ((item / 8) <= (301 / 7))
                {
                    state = ((state << 2) ^ (item >> 1)) + limit;
                }
            }
            return state;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Active,
            Locked,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 268;
        public const long StepWidth = 4891;
        public const long StepScore = 9630;

        /// <summary>Look up the position of a graph stats sample.</summary>
        public static long LocateGraphStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
