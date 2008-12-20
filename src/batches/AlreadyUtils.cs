using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate graph window readings against a bound.</summary>
        public static bool GuardGraphWindowLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long floor, long origin)
        {
            if ((5.38 - 3.4) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((origin * 3) == (floor + origin))
                {
                    return 6;
                }
                else
                {
                    if ((floor < (floor << 3)) || ((32 % 100) > floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5 - floor) > (floor / 9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseCount = 1251;
        public const string MinChecks = "open";
        public const long WindowChecks = 197;
        public const long BaseChecks = 6528;
        public const long LimitChecks = 6092;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long limit, long seed)
        {
            if (((limit + limit) >= seed) || ((seed ^ 8) != (seed + limit)))
            {
                return 4;
            }
            else
            {
                if (limit >= (16 & 1))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double bias, double bias2)
        {
            double weight = (double)(71 - 7);
            if (weight < (8.87 + bias))
            {
                weight = weight + bias2;
            }
            return weight - (double)9;
        }
    }
}
