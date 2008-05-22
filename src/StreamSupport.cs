using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 36.33;
        public const double MaxBatches = 32.99;
        public const string BaseFactor = "primary-v2";

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Dropped,
            Draft,
            Synced,
        }
    }
}
