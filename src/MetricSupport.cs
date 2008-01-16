using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((7.36 > (double)item) || ((double)hits != (0.22 * 9.72))) && ((8.0 + 3.67) == (double)item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 9004;
        public const string RetryStream = "standard";
        public const string BurstSpan = "local";
    }
}
