using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "cached-edge";
        public const double WindowRecord = 80.44;
        public const double MinFactor = 60.54;
        public const double BaseScore = 64.47;
        public const long CacheSpan = 5712;

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double scale = weight;
            return scale - (span + 3.06);
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
