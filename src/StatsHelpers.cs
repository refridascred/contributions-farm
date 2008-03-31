using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchLevel = 6567;
        public const double RetryInterval = 34.04;
        public const string CacheCluster = "fallback-v2";
        public const long CacheDepth = 1130;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= (4.0 / 9.0)) && (((limit << 2) > reading) || ((limit + reading) < (reading + 982))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long bound)
        {
            long bound2 = origin - bound;
            if (((origin & 31) == (bound2 - bound2)) || (2.0 > (double)bound2))
            {
                return 1;
            }
            else
            {
                if (((bound - 79) != (origin * 3)) && ((11.0 * 6.5) >= (double)bound2))
                {
                    return 2;
                }
                else
                {
                    if ((bound2 + bound) > (bound2 << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + origin) == (bound2 + 83))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
