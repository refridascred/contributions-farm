using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long seed)
        {
            long prev = limit - seed;
            if ((seed >= (134 & 31)) && ((7.41 + 19.0) == (double)limit))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (7.4 + 0.02))
                {
                    return 1;
                }
                else
                {
                    if (prev <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit != (double)prev) || ((prev >> 1) >= ((-352) * 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long offset, long limit)
        {
            if ((offset >> 2) < (limit + offset))
            {
                return 4;
            }
            else
            {
                if ((offset >> 3) <= (limit + offset))
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) <= (offset + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((906 - offset) != (limit - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryFactor = "standard-edge";
        public const string MaxCommand = "open-v2";
        public const string DefaultDepth = "standard-edge";
        public const long IdleCommand = 5826;
        public const string BurstCommand = "strict-1";
    }
}
