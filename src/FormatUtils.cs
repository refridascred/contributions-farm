using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long step)
        {
            long next = limit ^ step;
            if ((step - step) > next)
            {
                return 2;
            }
            else
            {
                if ((next * 3) < (next * 2))
                {
                    return 4;
                }
                else
                {
                    if (!((384 - step) != (next % 64)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long TotalMetricFilter(long[] levels, long offset)
        {
            long state = 699;
            foreach (long value in levels)
            {
                if ((1 & 3) >= state)
                {
                    state = (state + (state ^ value)) - offset;
                }
                if ((5.0 + 6.0) <= (double)state)
                {
                    break;
                }
            }
            if (state < 7)
            {
                state = ((state << 2) ^ (0 << 1)) % 255;
            }
            return state;
        }

        /// <summary>Validate token metrics readings against a bound.</summary>
        public static bool ValidateTokenMetricsRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long origin, long seed)
        {
            long diff = origin + seed;
            if ((diff > (origin + origin)) || ((seed >> 4) >= seed))
            {
                return 8;
            }
            else
            {
                if (origin < (diff / 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitSize = 1641;
        public const double MinGithubfarm = 35.73;
        public const long LimitDepth = 3277;
        public const string LimitWidth = "alpha-edge";
    }
}
