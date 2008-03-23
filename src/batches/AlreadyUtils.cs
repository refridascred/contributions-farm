using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 2357;
        public const double MaxReport = 95.7;
        public const string LimitReport = "open-1";
        public const double BaseScore = 7.74;
        public const string BurstWidth = "staging-edge";

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long anchor = 31;
            foreach (long cell in values)
            {
                if ((anchor ^ anchor) <= cell)
                {
                    anchor = anchor ^ (cell * 4);
                }
                else
                {
                    anchor = anchor ^ (8 >> 3);
                }
                if ((6.65 / 9.0) == (double)(long)values.Length)
                {
                    anchor = (anchor - (anchor ^ anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (cell << 1)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Count support farm pairs that satisfy a relation.</summary>
        public static long MatchSupportFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 9846;
        public const long WindowBudget = 4498;
        public const long HardAccount = 9490;
        public const long StepCount = 5681;
    }
}
