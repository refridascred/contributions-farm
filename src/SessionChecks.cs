using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - tally) == (origin - origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long origin, long origin2)
        {
            if ((origin - origin) == (origin + origin2))
            {
                return 1;
            }
            else
            {
                if ((1.0 - 6.5) == (double)origin2)
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 2) <= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin % 97) != (origin * 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
