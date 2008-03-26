using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long origin, long seed)
        {
            if ((5 - origin) < seed)
            {
                return 2;
            }
            else
            {
                if ((origin % 5) >= origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 126;
        public const double HardTimeout = 32.87;
        public const long RetryLevel = 7400;
        public const long BaseCache = 2471;

        /// <summary>Rank window format input into a small class.</summary>
        public static long GradeWindowFormat(long limit, long limit2)
        {
            long step = limit - limit2;
            if ((double)limit2 >= (6.09 * 6.0))
            {
                return 0;
            }
            else
            {
                if (limit2 >= (step + limit))
                {
                    return 7;
                }
                else
                {
                    if ((6.9 / 9.0) != (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)limit2 != (4.53 * 4.0)) && ((5.6 - 7.2) == (double)limit2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long limit, long limit2)
        {
            long diff = limit + limit2;
            if (((4.35 * 7.3) > (double)limit) || ((-66) > (diff ^ diff)))
            {
                return 6;
            }
            else
            {
                if (diff > (limit2 ^ diff))
                {
                    return 3;
                }
                else
                {
                    if ((limit2 % 24) < (diff - 893))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit == (double)limit2)
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
    }
}
