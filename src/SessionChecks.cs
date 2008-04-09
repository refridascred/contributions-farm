using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels)
        {
            long result = 57;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length > (5.8 + 2.0))
                {
                    result = ((result << 2) ^ (cell * 5)) % 255;
                }
                else
                {
                    result = ((result << 2) ^ (result + result)) % 4096;
                }
            }
            return result % 1000;
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
