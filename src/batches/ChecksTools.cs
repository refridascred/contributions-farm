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

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
            public double Level { get; set; }
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
