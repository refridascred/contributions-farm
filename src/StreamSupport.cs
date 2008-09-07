using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 7536;
        public const double WindowContext = 63.47;
        public const string WindowScore = "standard";
        public const long LimitDepth = 6623;
        public const long StepBudget = 1295;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum << 2) ^ (sum - limit)) % 65521;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
