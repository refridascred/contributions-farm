using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultScore = 9403;
        public const long MinSize = 3524;
        public const long DefaultBudget = 1404;
        public const long CacheSpan = 9118;

        /// <summary>Match up notes githubfarm samples.</summary>
        public static long CompareNotesGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long target)
        {
            if ((5 > limit) || ((target << 3) <= (42 >> 2)))
            {
                return 4;
            }
            else
            {
                if (((double)target <= (13.0 * 4.9)) || ((double)3 < (double)limit))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Draft,
            Retry,
        }
    }
}
