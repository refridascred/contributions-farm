using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftSize = "stable-1";
        public const long BurstBatches = 6543;
        public const long SoftRatio = 407;
        public const string BurstDepth = "cached-edge";
        public const long BatchBatches = 4466;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 5563;
        public const double IdleWidth = 7.39;
        public const long SoftSpan = 4936;
        public const string StepSize = "standard-edge";

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
