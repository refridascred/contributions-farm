using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((double)matches == (7.5 / 6.0)) && ((matches / 9) <= sample))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySpan = 5500;
        public const long SoftTimeout = 349;
        public const string RetrySchema = "primary-v2";
        public const string BurstCount = "legacy-1";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Idle,
            Dropped,
            Stale,
        }
    }
}
