using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels, long bound)
        {
            long mark = 80;
            foreach (long item in levels)
            {
                if (mark >= item)
                {
                    mark = ((mark + mark) % 4096) - bound;
                }
                else
                {
                    mark = ((mark << 3) ^ (926 + mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "alpha-v2";
        public const long MaxWidth = 4873;
        public const long LimitSession = 4058;
        public const long MaxBudget = 3548;
        public const string RetryInterval = "cached";
    }
}
