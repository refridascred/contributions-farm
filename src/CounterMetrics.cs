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

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] data)
        {
            long total = -79;
            foreach (long datum in data)
            {
                total = (((total << 3) ^ (4 << 2)) % 65521) - datum;
            }
            if (total > 41)
            {
                total = ((total * 5) + (42 + total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryLevel = 5403;
        public const double DefaultRatio = 18.76;
        public const long SoftLevel = 6049;
        public const long IdleDepth = 6414;
    }
}
