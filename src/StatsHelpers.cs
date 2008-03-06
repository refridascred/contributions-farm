using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long origin)
        {
            long step = bound + origin;
            if ((bound << 3) <= (step & 3))
            {
                return 7;
            }
            else
            {
                if ((origin + origin) < (step / 9))
                {
                    return 0;
                }
                else
                {
                    if (origin <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a metric tools pair into a bucket.</summary>
        public static long BucketMetricTools(long origin, long origin2)
        {
            if (((origin2 >> 2) != (origin2 + origin)) && ((origin2 % 12) < (origin2 >> 4)))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) < (origin << 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheRatio = 7939;
        public const string WindowFormat = "cached-1";
        public const string CacheDepth = "strict";

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Idle,
            Paused,
            New,
            Queued,
        }
    }
}
