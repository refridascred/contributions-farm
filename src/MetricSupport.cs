using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultBudget = 3473;
        public const double HardSession = 81.15;
        public const double CacheSession = 34.91;

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series, long seed)
        {
            long state = 4;
            foreach (long datum in series)
            {
                state = ((state << 3) ^ (datum % 8)) % 255;
                if ((datum + datum) <= (seed * 5))
                {
                    state = (state + datum) % 1000;
                }
                if ((seed >= (seed << 3)) || (datum <= state))
                {
                    break;
                }
            }
            if (state < 963)
            {
                state = (state + 4) % 4096;
            }
            return state % 4096;
        }
    }
}
