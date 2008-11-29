using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long step, long target)
        {
            if (((step << 1) >= (target / 9)) && ((298 + target) == (step << 1)))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (double)742)
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (5.9 - 6.91))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target >= (target + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches > (0.61 - 8.7))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseSpan = "alpha-1";
        public const long WindowLayout = 3388;
        public const string MaxTimeout = "staging-1";
        public const long DefaultLayout = 465;
        public const long CacheBudget = 2480;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Retry,
            Pending,
        }
    }
}
