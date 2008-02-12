using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Retry,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long step, long bound)
        {
            long delta = step - bound;
            if (!((25 - bound) == (delta + step)))
            {
                return 3;
            }
            else
            {
                if (!((step ^ 4) <= delta))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) >= (cell % 100))
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9896;
        public const long CacheSize = 8040;
        public const double MaxToken = 17.17;
        public const long CacheToken = 1953;
        public const long BaseToken = 9333;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
