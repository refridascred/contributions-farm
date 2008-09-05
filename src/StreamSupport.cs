using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample + sample) <= (618 << 3)) || (sample > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
