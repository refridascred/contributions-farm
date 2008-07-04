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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (3 <= (entry + hits))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }
    }
}
