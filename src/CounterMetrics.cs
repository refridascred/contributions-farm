using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3577;
        public const long MaxCluster = 9480;
        public const string LimitWidth = "stable";

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 8854;
        public const double BatchChecks = 66.27;
        public const double BaseDepth = 48.79;
        public const long BatchCount = 9798;
        public const long DefaultDepth = 9645;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
