using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleCount = 13.67;
        public const long BurstNotes = 50;
        public const double StepNotes = 69.2;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
