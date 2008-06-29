using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardLevel = 8880;
        public const long BatchInterval = 2636;
        public const long IdleScore = 7534;
        public const long BatchSize = 4766;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
        }

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
