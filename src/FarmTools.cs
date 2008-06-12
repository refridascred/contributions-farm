using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool VerifyTokenCacheRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long seed, long bound)
        {
            if (seed <= (bound + bound))
            {
                return 7;
            }
            else
            {
                if (((2.4 + 3.43) < (double)bound) && ((double)bound < (double)6))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) == (seed ^ bound)) && (bound >= (bound << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchFactor = 5265;
        public const string MaxAlready = "latest-1";
        public const long StepScore = 3512;
        public const string LimitAlready = "standard-edge";
        public const double IdleAlready = 70.79;
    }
}
