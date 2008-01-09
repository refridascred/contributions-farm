using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long floor, long bound)
        {
            long diff = floor ^ bound;
            if ((floor % 10) >= (861 ^ bound))
            {
                return 1;
            }
            else
            {
                if ((floor >= (diff - diff)) || ((double)floor >= (7.22 + 3.42)))
                {
                    return 5;
                }
                else
                {
                    if ((diff + bound) >= (floor + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheInterval = "alpha-edge";
        public const long SoftCount = 2549;
        public const long HardLevel = 4705;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryLevel = 5403;
        public const double DefaultRatio = 18.76;
        public const long SoftLevel = 6049;
        public const long IdleDepth = 6414;
    }
}
