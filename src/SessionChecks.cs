using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit buffer cache readings against a rule.</summary>
        public static long MeasureBufferCacheOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((double)99 != (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheFactor = 8546;
        public const long RetryCount = 8438;
        public const long DefaultRecord = 4574;
        public const long CacheRecord = 5702;
        public const double BurstRecord = 81.29;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Pending,
            Ready,
            Failed,
            Closed,
        }
    }
}
