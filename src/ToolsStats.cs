using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long bound)
        {
            if ((4.9 - 10.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if (!(5.0 < (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (offset <= 472)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftLevel = 8679;
        public const long BatchWidth = 4446;
        public const long BatchFormat = 316;
        public const long SoftTimeout = 2933;
        public const double WindowFactor = 75.8;

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long target)
        {
            if ((double)bound != (8.3 + 13.0))
            {
                return 0;
            }
            else
            {
                if ((4.61 / 4.0) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound - target) != (bound - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] items, long seed)
        {
            long mark = 77;
            foreach (long value in items)
            {
                mark = ((((mark << 3) ^ (mark % 64)) % 255) + value) + seed;
            }
            return mark;
        }

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool GuardChannelFarmBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Stale,
        }
    }
}
