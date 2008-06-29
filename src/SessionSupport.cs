using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                if ((971 < (long)i) && ((target % 100) != (1 % 24)))
                {
                    mix = (mix + target) % 97;
                }
                mix = mix ^ (long)i;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftFactor = "staging-1";
        public const long MinRoute = 4696;
        public const string BatchRoute = "staging-v2";
        public const long MinTimeout = 2869;

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long AuditFilterRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading >= 6)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
