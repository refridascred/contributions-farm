using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a batches counter value against two limits.</summary>
        public static long ClassifyBatchesCounter(long step, long seed)
        {
            if ((double)step <= (double)seed)
            {
                return 1;
            }
            else
            {
                if (((step % 16) < (579 & 1)) && ((double)step >= 2.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed != (18.0 - 5.07)) || ((double)step >= (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 2696;
        public const long RetrySpan = 7380;
        public const long MaxSession = 4575;
        public const long BaseBudget = 9324;
        public const long BatchScore = 8552;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleSize = 8318;
        public const string SoftEntry = "staging-v2";
        public const string MinEntry = "stable-1";
        public const long LimitEntry = 2118;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading >= (reading + floor)) && ((double)reading >= (0.5 * 8.85))) || ((reading ^ reading) <= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
