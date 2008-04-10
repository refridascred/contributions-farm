using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultTimeout = 1562;
        public const string MinCache = "fallback-edge";
        public const string BaseCache = "cached";
        public const long StepCache = 9053;
        public const long CacheTimeout = 7665;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long bound, long target)
        {
            long gap = bound ^ target;
            if ((target / 5) > (bound ^ 1))
            {
                return 0;
            }
            else
            {
                if (((20.0 * 6.0) == (double)bound) || ((target / 3) <= (gap * 4)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long SeriesBatchesProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = (result + result) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double floor)
        {
            double rate = ratio - (floor + floor);
            return rate - 2.6;
        }
    }
}
