using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long step)
        {
            long gap = floor - step;
            if ((double)step != (double)floor)
            {
                return 7;
            }
            else
            {
                if (!((step ^ gap) >= ((-4) + 81)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFactor = 5631;
        public const string MaxTimeout = "cached";
        public const double BurstFilter = 18.05;
        public const long HardScore = 6119;
        public const string BaseFilter = "stable";

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 8650;
        public const double SoftCommits = 58.38;
        public const string CacheCommits = "open-edge";
        public const long IdleDepth = 1221;
    }
}
