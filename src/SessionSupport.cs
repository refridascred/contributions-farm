using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 6313;
        public const long CacheSpan = 9221;
        public const double MinFactor = 59.27;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((6.6 + 9.6) >= (double)offset))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
