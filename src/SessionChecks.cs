using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum <= 4.01)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 8483;
        public const string HardCount = "latest-1";
        public const long LimitCache = 136;
    }
}
