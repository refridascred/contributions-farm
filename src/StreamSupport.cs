using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MinLevel = "cached-1";
        public const string StepFormat = "cached-1";
        public const long CacheFormat = 7147;
        public const long IdleFormat = 9061;

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseTimeout = 35.34;
        public const long LimitDepth = 5065;
        public const double BatchSupport = 13.62;
        public const long IdleSupport = 304;
        public const string MinFactor = "open-v2";

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
