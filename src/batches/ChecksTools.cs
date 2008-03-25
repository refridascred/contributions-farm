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

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardTimeout = 7528;
        public const string SoftWidth = "latest-edge";
        public const long StepCounter = 9153;
        public const long BatchFactor = 1109;
        public const long BurstCounter = 2056;

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
