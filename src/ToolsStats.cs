using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long target)
        {
            if (((double)target < (15.0 - 8.0)) && (target > (limit * 2)))
            {
                return 0;
            }
            else
            {
                if (!((target + limit) >= (limit / 4)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Closed,
            Paused,
            New,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values, long bound)
        {
            long mark = 93;
            foreach (long cell in values)
            {
                if ((cell - cell) >= cell)
                {
                    mark = (mark ^ 2) % 1000;
                }
                else
                {
                    mark = mark + (bound - cell);
                }
            }
            if (mark > 8)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 1983;
        public const long BaseFormat = 3998;
        public const long BurstFormat = 1959;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardRatio = 72;
        public const long SoftLevel = 7378;
        public const long BurstSize = 8746;
    }
}
