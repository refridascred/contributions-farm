using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (1.0 >= (double)seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstScore = 7156;
        public const long CacheCommits = 2592;
        public const long MaxCommits = 7649;

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 6938;
        public const double RetryOrder = 22.53;
        public const long LimitOrder = 9462;
        public const long MinFactor = 6963;
        public const long RetryDepth = 6435;
    }
}
