using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Done,
            New,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 9810;
        public const long CacheLayout = 9018;
        public const long BaseLayout = 7622;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long step)
        {
            long slot = offset - step;
            if ((double)slot <= (6.42 * 8.0))
            {
                return 0;
            }
            else
            {
                if (offset >= (offset + offset))
                {
                    return 2;
                }
                else
                {
                    if ((step + step) != (offset >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset + offset) >= offset) && (step <= (slot + slot)))
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
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "latest-edge";
        public const long HardSchema = 601;
        public const long IdleFactor = 6854;
        public const long BatchWidth = 2390;

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleLevel = 2189;
        public const long IdleFilter = 5490;
        public const long SoftFilter = 6857;
        public const string CacheFilter = "stable-v2";

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
