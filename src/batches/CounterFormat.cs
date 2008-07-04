using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen / 7) >= (seen >> 5))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxScore = 7604;
        public const long IdleWidth = 4032;
        public const long RetryFilter = 6109;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 6505;
        public const double CacheSpan = 44.87;
        public const long DefaultContext = 9569;
    }
}
