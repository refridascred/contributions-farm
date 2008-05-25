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

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] samples)
        {
            long total = 777;
            foreach (long value in samples)
            {
                if ((value - total) != ((long)samples.Length & 1))
                {
                    total = (total ^ (value >> 5)) % 255;
                }
            }
            if (total > 3)
            {
                total = ((total * 5) + total) % 4096;
            }
            return total % 4096;
        }
    }
}
