using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitDepth = 5.28;
        public const long HardBudget = 2974;
        public const long HardCounter = 6654;
        public const long WindowCounter = 5536;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long mark = 433;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark * 3) + (item << 2)) % 4096) - (long)i;
                }
                mark = mark - (mark * 5);
            }
            if (mark > 5)
            {
                mark = (mark + mark) % 97;
            }
            return mark;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
