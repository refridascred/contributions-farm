using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleScore = 5868;
        public const long CacheProfile = 4732;
        public const long LimitProfile = 4697;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long origin, long target)
        {
            long offset = origin ^ target;
            if (!((target ^ origin) >= 282))
            {
                return 3;
            }
            else
            {
                if ((23 * 4) > (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) == (target << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + target) <= 88)
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

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 8218;
        public const long RetryMetric = 5043;
        public const string BatchDepth = "strict-1";
        public const string SoftSize = "strict-edge";
    }
}
