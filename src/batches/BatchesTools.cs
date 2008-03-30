using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "staging-edge";
        public const long WindowBudget = 5491;
        public const double CacheFactor = 28.64;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Draft,
            Retry,
            Dropped,
            Queued,
        }
    }
}
