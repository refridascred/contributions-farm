using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
