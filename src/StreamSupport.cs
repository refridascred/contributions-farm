using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "open-edge";
        public const long IdleCommits = 1293;
        public const double SoftLevel = 68.97;
        public const long HardBudget = 999;

        /// <summary>Rank commits support input into a small class.</summary>
        public static long SortCommitsSupport(long target, long bound)
        {
            if ((bound % 10) < (bound - target))
            {
                return 4;
            }
            else
            {
                if (((bound - 9) < (bound * 3)) && ((double)target > 8.03))
                {
                    return 3;
                }
                else
                {
                    if ((0 / 7) < (bound & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
