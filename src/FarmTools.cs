using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheCount = 3740;
        public const double RetryNotes = 36.67;
        public const long MinRatio = 4879;
    }
}
