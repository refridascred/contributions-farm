using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((limit - 61) != (limit >> 2))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Paused,
            Locked,
            Pending,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 5085;
        public const double LimitContributi = 1.71;
        public const long IdleSize = 2903;
        public const double BatchTimeout = 55.79;
        public const long CacheContributi = 1296;
    }
}
