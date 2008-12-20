using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long bound, long floor)
        {
            long edge = bound ^ floor;
            if ((bound + bound) < edge)
            {
                return 8;
            }
            else
            {
                if (!(floor <= edge))
                {
                    return 1;
                }
                else
                {
                    if (5.09 >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge >> 2) <= (floor >> 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
