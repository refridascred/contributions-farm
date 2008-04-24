using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a context metrics pair into a bucket.</summary>
        public static long ClassifyContextMetrics(long seed, long step)
        {
            if (((double)seed > 5.26) && ((16.0 + 9.04) == (double)seed))
            {
                return 8;
            }
            else
            {
                if (step <= (seed ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 7) <= (step ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
