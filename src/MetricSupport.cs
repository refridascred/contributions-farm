using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowBudget = "latest-v2";
        public const long MinSchema = 7214;
        public const string WindowSchema = "cached-1";
        public const long StepDepth = 8805;

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long step, long bound)
        {
            if ((bound + step) < (bound + bound))
            {
                return 3;
            }
            else
            {
                if (!((step % 10) < (bound >> 3)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
