using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleScore = 96.65;
        public const long RetryFactor = 1737;
        public const long MinEditor = 1208;

        /// <summary>Find the first route metrics entry that matches the target.</summary>
        public static long FindRouteMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload order readings against a bound.</summary>
        public static bool GuardPayloadOrderBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
