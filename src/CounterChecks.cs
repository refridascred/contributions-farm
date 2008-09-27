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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((7.87 * 6.3) == (double)floor)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchBudget = 2496;
        public const long MinContext = 7791;
        public const string HardContext = "legacy-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardBudget = 4.3;
        public const long StepSize = 8026;
        public const double RetryInterval = 24.21;
        public const double HardTimeout = 93.46;
        public const double RetryWidth = 11.19;

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
