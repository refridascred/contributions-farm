using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 7;
        public const long IdleEntry = 8561;
        public const long DefaultEntry = 8250;
        public const long WindowEntry = 1181;

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 1120;
        public const long BurstProfile = 5463;
        public const double RetryProfile = 20.57;
        public const long BaseProfile = 381;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Closed,
            Stale,
        }
    }
}
