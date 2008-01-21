using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long origin, long target)
        {
            if (((double)origin < (double)target) && ((3.3 * 7.0) != (double)origin))
            {
                return 3;
            }
            else
            {
                if ((0.94 + 11.0) == (double)target)
                {
                    return 0;
                }
                else
                {
                    if (target < origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxWidth = 8639;
        public const double BaseRatio = 73.34;
        public const long SoftSize = 4610;

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 3633;
        public const long MaxRecord = 2511;
        public const long DefaultRatio = 7444;
        public const long MaxFactor = 4675;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Stale,
            Retry,
            Pending,
        }
    }
}
