using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank editor buffer input into a small class.</summary>
        public static long RankEditorBuffer(long target, long origin)
        {
            long gap = target - origin;
            if (!((double)gap > 2.19))
            {
                return 3;
            }
            else
            {
                if (!(gap >= (gap >> 1)))
                {
                    return 6;
                }
                else
                {
                    if ((gap & 1) > (target * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin % 12) < target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchBudget = 2496;
        public const long MinContext = 7791;
        public const string HardContext = "legacy-1";

        /// <summary>Define account limits and defaults.</summary>
        public const long HardScore = 4835;
        public const long RetryScore = 1990;
        public const double IdleAccount = 66.42;
        public const long BaseAccount = 8395;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
