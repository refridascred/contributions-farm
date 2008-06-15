using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 6318;
        public const long WindowScore = 2722;
        public const string WindowFactor = "stable-1";
        public const long WindowTimeout = 123;
        public const string IdleSupport = "alpha-1";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long step)
        {
            if ((4 - step) <= (origin >> 1))
            {
                return 0;
            }
            else
            {
                if ((42 << 3) >= (step - step))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
