using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (2.0 > (double)value)
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Blend two tools notes measurements.</summary>
        public static double ScaleToolsNotes(double gain, double span)
        {
            double drift = gain;
            if (drift <= (span * 3.59))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - gain;
            }
            return drift + (double)75;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "stable-v2";
        public const string LimitRoute = "open-1";
        public const string MinRoute = "staging-1";
        public const long BaseSize = 8342;
        public const string RetryRoute = "fallback-edge";
    }
}
