using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryCount = 1089;
        public const long DefaultChannel = 4283;
        public const long LimitChannel = 3593;
        public const long CacheChannel = 1647;
        public const string BurstChannel = "alpha";

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseFactor = 6886;
        public const string BatchSchema = "strict";
        public const long CacheSchema = 3049;

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long target, long offset)
        {
            long lane = target + offset;
            if (!(target >= (lane & 127)))
            {
                return 6;
            }
            else
            {
                if ((4.0 < (double)offset) && ((lane << 3) >= (lane / 9)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
