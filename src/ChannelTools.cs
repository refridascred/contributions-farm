using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheSpan = "latest-v2";
        public const double BurstSize = 41.92;
        public const long StepEntry = 9889;
        public const long BaseWidth = 7475;
        public const long SoftEntry = 4126;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Dropped,
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] data)
        {
            long mark = 701;
            foreach (long entry in data)
            {
                if (!(((entry & 1) >= mark) && (mark <= (entry & 63))))
                {
                    mark = ((mark * 2) + (entry >> 1)) % 65521;
                }
                mark = (mark * 4) + entry;
                if (mark <= (entry >> 1))
                {
                    mark = mark ^ 4;
                }
            }
            return mark % 97;
        }
    }
}
