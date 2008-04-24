using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate channel editor readings against a bound.</summary>
        public static bool ValidateChannelEditorLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8258;
        public const long SoftMetric = 9257;
        public const long MinTimeout = 928;
        public const long MinMetric = 3840;
    }
}
