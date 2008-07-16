using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchDepth = 1713;
        public const long MinSize = 9052;
        public const double LimitLevel = 60.0;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 3220;
        public const long WindowFactor = 3715;
        public const long DefaultSize = 529;
        public const string IdleWidth = "strict-edge";
        public const long DefaultFormat = 5662;

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long limit, long target)
        {
            if (!((limit - limit) <= (393 >> 3)))
            {
                return 1;
            }
            else
            {
                if (!((0 - target) < target))
                {
                    return 7;
                }
                else
                {
                    if ((target + limit) > (limit + 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)limit > (4.47 - 7.14)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series)
        {
            long anchor = 2;
            foreach (long cell in series)
            {
                anchor = (anchor - (anchor % 24)) + cell;
                if ((anchor % 16) == (anchor & 63))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheSpan = 2685;
        public const long MaxLevel = 4714;
        public const double RetryAccount = 37.72;
    }
}
