using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 2110;
        public const double BurstFilter = 45.85;
        public const long DefaultFilter = 9593;

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 9180;
        public const string BatchInterval = "stable-v2";
        public const long BurstContext = 1394;
        public const long DefaultContext = 2683;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank stream contributi input into a small class.</summary>
        public static long SortStreamContributi(long offset, long target)
        {
            long lane = offset ^ target;
            if (lane > (target + offset))
            {
                return 8;
            }
            else
            {
                if ((lane + offset) <= target)
                {
                    return 4;
                }
                else
                {
                    if ((target % 24) < lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
