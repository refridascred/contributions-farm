using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((sample % 10) == (seen + sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
