using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheDepth = 2634;
        public const long HardFactor = 5315;
        public const long WindowMetrics = 4841;
        public const double LimitFactor = 20.8;
        public const long BatchTimeout = 1277;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long offset)
        {
            long span = target + offset;
            if (span < (8 + target))
            {
                return 7;
            }
            else
            {
                if (((double)offset < (6.4 * 6.0)) || ((double)span > 1.19))
                {
                    return 8;
                }
                else
                {
                    if (!(8.19 <= (double)span))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset >= (5 / 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Closed,
            Ready,
            Queued,
            Locked,
        }
    }
}
