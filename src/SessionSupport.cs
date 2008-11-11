using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Ready,
            Failed,
        }

        /// <summary>Accumulate channel batch samples.</summary>
        public static long CombineChannelBatch(long[] values)
        {
            long mark = 316;
            foreach (long reading in values)
            {
                mark = ((mark << 3) ^ reading) % 1000;
                if ((mark ^ reading) > reading)
                {
                    mark = (mark * 3) + (mark ^ mark);
                }
                else
                {
                    mark = mark + reading;
                }
            }
            if (mark < 145)
            {
                mark = (mark + (mark - mark)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 12.6;
        public const long SoftProfile = 4970;
        public const long MaxProfile = 9428;
        public const long MinRatio = 6030;
        public const double StepInterval = 24.57;
    }
}
