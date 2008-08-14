using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseFactor = "standard-1";
        public const string RetryCache = "stable";
        public const string LimitInterval = "cached-1";
        public const double SoftLevel = 97.49;
        public const long LimitLevel = 8342;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long limit)
        {
            if ((limit > (limit - limit)) && (target > (limit + 407)))
            {
                return 3;
            }
            else
            {
                if (limit <= (target - 9))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double load = span;
            if (load > load)
            {
                load = (load + (8.4 * 4.0)) - ratio;
            }
            else
            {
                load = load - span;
            }
            return load + (load - span);
        }
    }
}
