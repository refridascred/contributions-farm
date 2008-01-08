using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "latest-edge";
        public const long DefaultLayout = 876;
        public const long StepLevel = 3915;
    }
}
