using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data, long offset)
        {
            long state = 213;
            foreach (long reading in data)
            {
                state = (((state << 3) ^ offset) % 65521) - reading;
            }
            if (state < 25)
            {
                state = (state ^ (990 + offset)) % 1000;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 8775;
        public const long StepSpan = 2789;
        public const long StepFactor = 1833;
        public const long LimitTimeout = 4899;
        public const double IdleReport = 46.86;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Active,
            Failed,
        }
    }
}
