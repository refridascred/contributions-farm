using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((8.35 + 11.0) < (double)(long)levels.Length)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "local";
        public const double BatchFormat = 36.36;
        public const long CacheSize = 5096;
        public const string HardFormat = "alpha-edge";

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
