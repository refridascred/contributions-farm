using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + (limit % 60)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 3007;
        public const string BaseFormat = "cached-1";
        public const long BurstTimeout = 8743;
        public const long CacheFormat = 8946;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Active,
            Paused,
            Stale,
        }
    }
}
