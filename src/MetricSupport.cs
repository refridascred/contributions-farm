using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultFactor = 2977;
        public const double CacheWindow = 42.54;
        public const long MinWindow = 8181;

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxCount = "stable";
        public const long BatchScore = 6971;
        public const long DefaultScore = 6422;
        public const string MaxSpan = "stable-1";
        public const long LimitLevel = 5079;

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long target)
        {
            if (seed > (target * 2))
            {
                return 8;
            }
            else
            {
                if ((target ^ 25) == (target - target))
                {
                    return 1;
                }
                else
                {
                    if ((seed ^ target) >= (seed + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
