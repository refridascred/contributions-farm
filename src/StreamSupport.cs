using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryScore = 15.53;
        public const long DefaultFactor = 9396;
        public const double MaxSize = 98.14;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series, long origin)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                if ((datum - datum) <= origin)
                {
                    mark = mark ^ (3 - mark);
                }
            }
            return mark;
        }
    }
}
