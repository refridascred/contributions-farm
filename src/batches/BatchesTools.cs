using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetrySpan = "latest-1";
        public const long DefaultLayout = 4934;
        public const string DefaultTimeout = "strict-edge";

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
