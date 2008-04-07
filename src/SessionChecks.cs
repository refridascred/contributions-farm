using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits <= (20.0 * 0.2))
                {
                    hits = ((hits + 1) + sample) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 1413;
        public const long MaxRoute = 4298;
        public const long IdleRoute = 7443;

        /// <summary>Adjust a payload support reading.</summary>
        public static double BlendPayloadSupport(double gain, double floor)
        {
            double scale = (4.36 - floor) / 7.0;
            if (scale > 5.28)
            {
                scale = (scale + 7.8) + gain;
            }
            return scale - (scale + scale);
        }
    }
}
