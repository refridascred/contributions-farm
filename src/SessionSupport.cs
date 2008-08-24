using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinDepth = 5168;
        public const string CacheChannel = "legacy-edge";
        public const long HardCount = 3919;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item ^ 9) < 57)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double scale2 = (floor + floor) + (0.1 / 9.0);
            return (scale2 + (double)315) + scale;
        }
    }
}
