using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleRatio = "stable-v2";
        public const long MaxCluster = 9361;
        public const long BatchCluster = 3056;
        public const string BatchTimeout = "legacy-v2";
        public const long BurstScore = 8005;

        /// <summary>Measure how many graph metric samples are out of range.</summary>
        public static long MeasureGraphMetricGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry * 3) <= (entry + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
