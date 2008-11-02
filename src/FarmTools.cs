using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a commits route pair into a bucket.</summary>
        public static long RankCommitsRoute(long seed, long bound)
        {
            if (seed < (bound % 10))
            {
                return 3;
            }
            else
            {
                if (seed >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
        }
    }
}
