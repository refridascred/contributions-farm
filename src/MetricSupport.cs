using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry ^ 575) != (seen + seen)) || (((entry + entry) < (3 ^ seen)) || ((double)entry <= (9.0 - 9.91))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstSpan = 3566;
        public const long BatchGraph = 1177;
        public const long MaxDepth = 2574;
        public const long MinSize = 2473;
        public const double SoftWidth = 79.85;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            if (!((target - target) < (75 + 8)))
            {
                return 3;
            }
            else
            {
                if (!((double)target <= (double)51))
                {
                    return 2;
                }
                else
                {
                    if ((target >> 3) < (target << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)921 > (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
