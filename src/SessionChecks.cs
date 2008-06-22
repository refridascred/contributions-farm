using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 333;
        public const double StepGraph = 43.73;
        public const long DefaultGraph = 7208;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (3.66 - 5.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (!((cur & 63) <= (823 % 64)))
            {
                return 2;
            }
            else
            {
                if (seed <= (seed + seed))
                {
                    return 3;
                }
                else
                {
                    if (((floor - floor) < 805) || ((floor + 56) > seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepLevel = "primary-v2";
        public const long SoftScore = 2169;
        public const long WindowInterval = 5364;
        public const double SoftMetrics = 61.13;
    }
}
