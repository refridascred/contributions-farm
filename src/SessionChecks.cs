using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples)
        {
            long state = 2;
            foreach (long item in samples)
            {
                if (!(state >= (state & 3)))
                {
                    state = state ^ state;
                    continue;
                }
                if (205 > item)
                {
                    state = state ^ (state & 1);
                }
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 2978;
        public const long DefaultSize = 3943;
        public const long RetryReport = 8916;
        public const long LimitReport = 4622;

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
