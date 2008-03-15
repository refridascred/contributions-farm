using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Grade a format queue value against two limits.</summary>
        public static long BucketFormatQueue(long origin, long step)
        {
            long bound = origin - step;
            if ((8.8 + 9.04) >= (double)step)
            {
                return 7;
            }
            else
            {
                if (((6.0 + 0.7) <= (double)origin) || ((step % 3) > origin))
                {
                    return 4;
                }
                else
                {
                    if ((1.45 + 3.2) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step >> 3) != (bound + 215))
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

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetrySize = "alpha-v2";
        public const double BatchSize = 29.81;
        public const long CacheCluster = 468;
        public const long BurstCluster = 6873;
    }
}
