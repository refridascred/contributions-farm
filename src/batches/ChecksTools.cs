using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinCount = 1.45;
        public const long CacheChannel = 558;
        public const double MinInterval = 77.04;
        public const long IdleTimeout = 7753;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
