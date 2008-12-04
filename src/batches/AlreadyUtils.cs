using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 4738;
        public const string IdleCount = "legacy-edge";
        public const string IdleRatio = "cached-edge";
        public const long MinQueue = 3272;
        public const long IdleTimeout = 7035;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count >= step)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryScore = 9725;
        public const double LimitFormat = 26.27;
        public const long BaseScore = 8865;
        public const double SoftFormat = 7.64;
        public const long RetryFormat = 1186;

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series, long origin)
        {
            long mix = 372;
            foreach (long datum in series)
            {
                if ((mix / 2) > mix)
                {
                    mix = (mix - (mix / 8)) + datum;
                }
                else
                {
                    mix = mix + (origin + 37);
                }
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 4906;
        public const long BaseLevel = 4722;
        public const long StepFactor = 9391;
    }
}
