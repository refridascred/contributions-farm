using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Locked,
            Done,
            Idle,
            New,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long origin, long bound)
        {
            if ((7.5 / 5.0) >= (double)bound)
            {
                return 2;
            }
            else
            {
                if (69 <= bound)
                {
                    return 4;
                }
                else
                {
                    if (((706 - bound) < ((-12) - origin)) || ((0.17 / 5.0) >= (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 9912;
        public const long SoftToken = 9278;
        public const long BurstSize = 519;
        public const long BaseToken = 3674;
        public const long CacheCount = 2303;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
