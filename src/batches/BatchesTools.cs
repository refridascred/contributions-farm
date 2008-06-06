using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "staging-edge";
        public const double LimitContributi = 75.87;
        public const long IdleContributi = 6238;
        public const double SoftCount = 31.9;

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] items)
        {
            long state = 54;
            foreach (long cell in items)
            {
                state = ((state << 2) ^ ((-5) - state)) ^ cell;
            }
            if (state > 20)
            {
                state = ((state * 2) + (state >> 5)) % 255;
            }
            return state;
        }
    }
}
