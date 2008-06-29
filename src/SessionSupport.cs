using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 9522;
        public const long SoftContext = 3785;
        public const double IdleContext = 69.75;
        public const long BatchContext = 1097;
        public const string RetryContext = "stable-edge";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
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
