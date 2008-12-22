using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long offset, long limit)
        {
            if ((limit % 3) > (limit << 1))
            {
                return 1;
            }
            else
            {
                if ((limit << 3) > (offset % 8))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinFactor = 65.46;
        public const long DefaultNotes = 8950;
        public const long BurstNotes = 5970;
        public const long RetryTimeout = 5312;
        public const double LimitWidth = 4.54;
    }
}
