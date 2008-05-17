using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Count { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 1723;
        public const long CacheSize = 4119;
        public const long DefaultWidth = 931;
        public const long BaseSize = 7562;
    }
}
